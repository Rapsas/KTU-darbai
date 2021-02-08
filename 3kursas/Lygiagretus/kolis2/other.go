package main

import "fmt"

func siuntejas(toGrupuotojas, exit chan int, masyvas []int) {
	for i := 0; i < 5; i++ {
		toGrupuotojas<- masyvas[i]
	}
	exit<- 0
}

func grupuotojas(toGrupuotojas, toSurinkejas1, toSurinkejas2, toSurinkejas3, nutraukimas chan int) {

	doWork := true
	for doWork {
		select {
		case <-nutraukimas:
			doWork = false
		case skaicius := <- toGrupuotojas:
			if skaicius < 0 {
				// persiusti pirmam surinkejui
				toSurinkejas1<- skaicius
			} else if skaicius >= 0 && skaicius < 10 {
				// persiusti antram surinkejui
				toSurinkejas2<- skaicius
			} else if skaicius >= 10 && skaicius < 20 {
				// persiusti treciam surinkejui
				toSurinkejas3<- skaicius
			}
		}
	}
}

func surinkejas_sexy (toSurinkejas, nutraukimas chan int, name int, exit chan int) { // Python has the big gay xDDDDD~~~
	counter := 0
	sum := 0
	doWork := true
	for doWork {
		select {
		case val:= <-toSurinkejas:
			counter++
			sum += val
		case <-nutraukimas:
			doWork = false
		}
	}
	fmt.Println(fmt.Sprintf("Surinkejas %v: \nSkaitliukas: %v \nSuma: %v\n", name, counter, sum))
	exit <- 0
}


func main() {
	toSurinkejas1 := make(chan int)
	toSurinkejas2 := make(chan int)
	toSurinkejas3 := make(chan int)

	toGrupuotojas := make(chan int)
	exit := make(chan int)
	nutraukimasG := make(chan int) // grupuotojo
	nutraukimasS := make(chan int) // surinkejo

	array1 := []int{0,-10, 20, 69, 420}
	array2 := []int{1, 11, 2, -69, 9}
	array3 := []int{60,-1, 2, 9, 2}
	array4 := []int{19, 5, 14, 8, -9}


	go siuntejas(toGrupuotojas, exit, array1)
	go siuntejas(toGrupuotojas, exit, array2)
	go siuntejas(toGrupuotojas, exit, array3)
	go siuntejas(toGrupuotojas, exit, array4)

	go grupuotojas(toGrupuotojas, toSurinkejas1, toSurinkejas2, toSurinkejas3, nutraukimasG)

	go surinkejas_sexy(toSurinkejas1, nutraukimasS, 1, exit)
	go surinkejas_sexy(toSurinkejas2, nutraukimasS, 2, exit)
	go surinkejas_sexy(toSurinkejas3, nutraukimasS, 3, exit)


	for i := 0; i < 4; i++ { // Laukiama kol pasibaigs siuntejai
		<-exit
	}

	nutraukimasG<- 0

	for i := 0; i < 3; i++ { // pabaigiami surinkejai_sexy
		nutraukimasS<- 0
		<-exit
	}

	fmt.Println("Ur mom xDDD dies in her sleep >:(")
}
