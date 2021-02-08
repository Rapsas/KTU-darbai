package main

import (
	"encoding/json"
	"fmt"
	"io/ioutil"
	"log"
	"os"
	"strings"
	"sync"
)

const tCount = 3
const innerSize = 20
const numFilter = 1

type dataType struct {
	Text    string  `json:"string"`
	Num     int     `json:"int"`
	Decimal float32 `json:"double"`
	Result  float32
}

type DataArr []dataType

func (d DataArr) Len() int {return len(d)}
func (d DataArr) Less(i, j int) bool { return d[i].Num < d[j].Num}
func (d DataArr) Swap(i, j int) {d[i], d[j] = d[j], d[i]}

func readData(path string) []dataType {
	file, err := ioutil.ReadFile(path)

	if err != nil {
		log.Panic("Couldn't read file " + path)
	}

	var data []dataType

	err = json.Unmarshal([]byte(file), &data)

	if err != nil {
		log.Println(err)
		log.Panic("JSON marshal fault")
	}

	return data
}

type Monitor struct {
	mux *sync.Mutex
	takeCond *sync.Cond
	getCond *sync.Cond
	data []dataType
	slot int
	active bool
}

type AsyncStore struct {
	mux sync.Mutex
	data DataArr
}

func newMonitor() *Monitor {
	mux := &sync.Mutex{}
	monitor := Monitor{
		mux: mux,
		takeCond: &sync.Cond{L:mux},
		getCond: &sync.Cond{L:mux},
		data: make([]dataType, innerSize),
		slot: -1,
		active: false,
	}

	return &monitor
}

func (m *Monitor) add(data dataType){
	// Acquire mutex, add data, release mutex, signal cv
	m.mux.Lock()

	for m.slot + 1 >= innerSize {
		if !m.active {
			return
		}

		m.getCond.Wait()
	}

	m.slot++
	log.Println("Adding to: ", m.slot)
	m.data[m.slot] = data

	m.mux.Unlock()
	m.takeCond.Signal()
}

func (m *Monitor) get() *dataType {
	// Acquire mutex
	m.mux.Lock()

	// Defer stack
	defer m.getCond.Signal()
	defer m.mux.Unlock()

	for m.slot == -1 {
		if !m.active  {
			return nil
		}

		// Wait until there is anything to take
		m.takeCond.Wait()
	}

	log.Println("Taking from: ", m.slot)
	data := m.data[m.slot]
	m.slot--
	return &data
}

func (s *AsyncStore) add(data dataType) {
	// Lock, add, unlock
	s.mux.Lock()

	// Sort
	var index = 0 // Insert index

	for i, s := range s.data {
		if data.Num > s.Num {
			index = i + 1
		}
	}

	s.data = append(s.data, data)
	copy(s.data[index + 1:], s.data[index:])
	s.data[index] = data

	s.mux.Unlock()
}

func (s *AsyncStore) toFile(file string) {
	// Print to file
	f, err := os.Create(file)

	if err != nil {
		log.Panic(err)
	}

	defer f.Close()

	// Header
	f.WriteString(fmt.Sprintf("%20v|%10v|%10v|%15v\n", "String", "Number", "Decimal", "Result"))
	f.WriteString(fmt.Sprintf("%v\n", strings.Repeat("-", 55 + 2)))

	for _, elem := range s.data {
		f.WriteString(fmt.Sprintf("%20v|%10v|%10v|%15v\n", elem.Text, elem.Num, elem.Decimal, elem.Result))
	}
}

func tFunc(group *sync.WaitGroup, monitor *Monitor, sorted *AsyncStore) {
	for {
		data := monitor.get()

		// Monitor terminated
		if data == nil {
			break
		}

		data.Result = float32(data.Num) * data.Decimal * float32(data.Text[0])

		if data.Result > numFilter {
			// Add to sorted
			sorted.add(*data)
		}
	}

	group.Done()
}

func main(){
	// Create monitor
	var monitor = newMonitor()
	var storage = AsyncStore{}
	monitor.active = true

	// Read data
	dataArr := readData("IFF8-13_PaulauskasM_L1_dat_1.json")

	// Start threads
	var wg sync.WaitGroup
	for i := 0; i < tCount; i++ {
		wg.Add(1)
		go tFunc(&wg, monitor, &storage)
	}

	// Start adding data
	for _, elem := range dataArr {
		monitor.add(elem)
	}

	// Shutdown procedure
	monitor.active = false

	// Wait for finish
	wg.Wait()

	// Process info
	log.Println("Before filter: ",len(dataArr))
	log.Println("After  filter: ",len(storage.data))

	// Output to file
	storage.toFile("IFF8-13_PaulauskasM_L1_rez.txt")
}