package main

import (
	"encoding/json"
	"fmt"
	"io/ioutil"
	"log"
	"os"
	"strconv"
	"strings"
)

const tCount = 25
const innerSize = 5
const numFilter = 1

var fileFeedDone = false
var sendOverDone = false
var processingDone = 0
var resultDone = false
var sendingToWorkersDone = false

type dataType struct {
	Text    string  `json:"string"`
	Num     int     `json:"int"`
	Decimal float32 `json:"double"`
	Result  float32
}

type DataArr []dataType

func (d DataArr) Len() int           { return len(d) }
func (d DataArr) Less(i, j int) bool { return d[i].Num < d[j].Num }
func (d DataArr) Swap(i, j int)      { d[i], d[j] = d[j], d[i] }

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

func toFile(file string, data []dataType) {
	// Print to file
	f, err := os.Create(file)

	if err != nil {
		log.Panic(err)
	}

	defer f.Close()

	// Header
	f.WriteString(fmt.Sprintf("%20v|%10v|%10v|%15v\n", "String", "Number", "Decimal", "Result"))
	f.WriteString(fmt.Sprintf("%v\n", strings.Repeat("-", 55 + 2)))

	for _, elem := range data {
		f.WriteString(fmt.Sprintf("%20v|%10v|%10v|%15v\n", elem.Text, elem.Num, elem.Decimal, elem.Result))
	}
}

func tFunc(recvChan chan dataType, resultChan chan dataType, workerRequestData chan<- int) {

	defer func() { processingDone += 1 }()
	defer log.Println("Worker: Done")

	for {
		select {
		case workerRequestData <- 1:
		}
		//workerRequestData <- 1 //Worker requesting data

		select {
		case data := <-recvChan:
			data.Result = float32(data.Num) * data.Decimal * float32(data.Text[0])
			if data.Result > numFilter {
				log.Println("Worker: sending to results " + data.Text)
				resultChan <- data
			}
		default:
			//nothing
		}

		if sendingToWorkersDone{
			log.Println("Worker: Done. Remaining threads: " + strconv.Itoa(processingDone))
			return
		}
	}
	// Expensive operation
	//time.Sleep(1 * time.Second)
}


func dataThread(recvChannel chan dataType, sendChannel chan dataType, workerRequestData <-chan int) {
	var innerArray = make([]dataType, innerSize)
	var slot = 0



	// Start loop
	for true {
		if slot+1 < innerSize {
			select {
			case receivedData := <-recvChannel:
				log.Println("Received", receivedData.Text)

				innerArray[slot] = receivedData
				slot++
			default:
				// No messages in the channel
			}
		}

		if slot > 0 {
			select {
			case <-workerRequestData: //If array not empty, this thread is waiting for a data request
				slot = slot - 1

				sendChannel <- innerArray[slot]
			default:
				// No messages in the channel
			}


		} else {
			if fileFeedDone {
				sendingToWorkersDone = true
				for i := 0; i < tCount; i++ {
					<-workerRequestData
				}
				close(sendChannel)
				log.Println("All data sent")
				return
			}
		}
	}

	sendOverDone = true
}

func resultThread(resultChan chan dataType, finalChan chan []dataType) {
	results := make([]dataType, 0)


	defer func() { resultDone = true }()
	defer func() { log.Println(results) }()

	for {
		select {
		case data := <-resultChan:
			// Sort
			var index = 0 // Insert index

			for i, s := range results {
				if data.Num > s.Num {
					index = i + 1
				}
			}

			results = append(results, data)
			copy(results[index+1:], results[index:])
			results[index] = data
			log.Println("Result: added " + data.Text)
		default:
			// Nothing
			if processingDone == tCount {
				// Send data
				memcpy := make([]dataType, len(results))
				copy(memcpy, results)

				finalChan <- memcpy

				return
			}
		}
	}
}

func main() {
	// Read data
	dataArr := readData("IFF8-13_PaulauskasM_L1_dat_1.json")

	// Start threads
	dataRecv := make(chan dataType, innerSize)
	dataSend := make(chan dataType, innerSize)
	workerRequestData := make(chan int)
	resultChan := make(chan dataType, innerSize)
	finalChan := make(chan []dataType)

	//var wg sync.WaitGroup


	go dataThread(dataRecv, dataSend, workerRequestData)


	go resultThread(resultChan, finalChan)

	for i := 0; i < tCount; i++ {

		go tFunc(dataSend, resultChan, workerRequestData)
	}

	// Start adding data
	for _, elem := range dataArr {
		log.Println("Sending", elem.Text)

		// We send data here and wait for it to return
		dataRecv <- elem
	}
	log.Println("Main thread: all data sent to via data channel")
	fileFeedDone = true

	finalData := <-finalChan
	toFile("sorted.txt", finalData)

	log.Println("Program end")
}


// Nuimti selectus
// Selectas su dviem kanalais