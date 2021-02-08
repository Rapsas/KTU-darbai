package main

import (
	"fmt"
	"time"
)

func surinkejas(toSurinkejas, nutraukimas, surinkejoRez chan int) {
	counter := 0
	doWork := true
	for doWork {
		select {
		case <-nutraukimas:
			doWork = false
			surinkejoRez<- counter

		case <-toSurinkejas:
			counter++
		}
	}
}

func skaiciuotojai(toSkaiciuotojas, toSurinkejas, atsakymas chan int) {

	for {
		val := <- toSkaiciuotojas
		count := 0
		for i := 2; i < val; i++ {
			if val % i == 0 {
				count++
			}
		}

		if count == 4 {
			// persiusti surinkejui
			toSurinkejas<- val
			atsakymas<- -1
		}else if count == 3 {
			atsakymas<- val
			break // fucking die :(
		} else {
			atsakymas<- -1
		}

	}
}

func main() {

	t:= time.Now()
	toSkaiciuotojas := make(chan int)
	toSurinkejas := make(chan int)
	atsakymas := make(chan int)
	nutraukimas := make(chan int)
	surinkejoRez := make(chan int)

	// Paleidimai
	for i := 0; i <5; i++ {
		go skaiciuotojai(toSkaiciuotojas, toSurinkejas, atsakymas)
	}
	go surinkejas(toSurinkejas, nutraukimas, surinkejoRez)


	doWork := true
	for i := 15000; doWork; i+=5{
		toSkaiciuotojas<- i
		toSkaiciuotojas<- i+1
		toSkaiciuotojas<- i+2
		toSkaiciuotojas<- i+3
		toSkaiciuotojas<- i+4

		for j:=0; j < 5; j++ {
			ats := <-atsakymas
			if ats > 0 {

				nutraukimas<- 0
				sur := <- surinkejoRez
				fmt.Println("Skaicius dalinantis is 3: ",ats)
				fmt.Println("Sk kiekis: ",ats - 15000)
				fmt.Println("Dalinantys is 4 kiekis: ", sur)
				doWork = false
			}
		}
	}

	t1 := time.Now()
	fmt.Println("Užtruko laiko: ", t1.Sub(t))

	fmt.Println("I die")
}
