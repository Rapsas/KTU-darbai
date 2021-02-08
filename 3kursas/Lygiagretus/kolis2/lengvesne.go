package main

import "fmt"


func siuntejai(arr []int, toGrupuotojas, exit chan int) {
	for i := 0; i < 5; i++{
		toGrupuotojas <- arr[i]
		//fmt.Print(numb)
	}
	exit <- 0
}

func grupuotojai(fromSiuntejas, toSurinkejas1, toSurinkejas2, toSurinkejas3, nutraukimas chan int) {
	for {
		select {
		case <-nutraukimas:
			//fmt.Println("Gautas singanalas is pagrindinio")
			return
		case numb := <-fromSiuntejas:
			if numb < 0 {
				toSurinkejas1 <- numb
			} else if 0 <= numb && numb < 10 {
				toSurinkejas2 <- numb
			} else if 10 <= numb && numb < 20{
				toSurinkejas3 <- numb
			}
		}
	}
	defer fmt.Println("Grupuotojas: DONE")
}

func surinkejai(fromGrupuotojas, nutraukimas, exit chan int, name int) {
	counter := 0
	sum := 0

	for {
		select {
		case <-nutraukimas:
			exit <- 0
			fmt.Println(fmt.Sprintf("Surinkejas %v: \nSkaitliukas: %v \nSuma: %v\n", name, counter, sum))
			return
		case val := <-fromGrupuotojas:
			sum += val
			counter++
		}
	}
}

func main() {
	toSurinkejas1 := make(chan int)
	toSurinkejas2 := make(chan int)
	toSurinkejas3 := make(chan int)

	array1 := []int{0,-10, 20, 69, 420}
	array2 := []int{1, 11, 2, -69, 9}
	array3 := []int{60,-1, 2, 9, 2}
	array4 := []int{19, 5, 14, 8, -9}

	toGrupuotojas := make(chan int)
	exit := make(chan int)
	nutraukimasG := make(chan int)
	nutraukimasS := make(chan int)

	go siuntejai(array1, toGrupuotojas, exit)
	go siuntejai(array2, toGrupuotojas, exit)
	go siuntejai(array3, toGrupuotojas, exit)
	go siuntejai(array4, toGrupuotojas, exit)

	go grupuotojai(toGrupuotojas, toSurinkejas1, toSurinkejas2, toSurinkejas3, nutraukimasG)

	go surinkejai(toSurinkejas1, nutraukimasS, exit, 1)
	go surinkejai(toSurinkejas2, nutraukimasS, exit, 2)
	go surinkejai(toSurinkejas3, nutraukimasS, exit, 3)

	for i := 0; i < 4; i++ { // Laukiama kol pasibaigs siuntejai
		<-exit
		//fmt.Println("Gautas singanalas is siuntejo")
	}

	nutraukimasG<- 0
	//fmt.Println("Siunciu signala grupuotojui")

	for i := 0; i < 3; i++ { // pabaigiami surinkejai_sexy
		nutraukimasS<- 0
		<-exit
	}

	fmt.Print("Job done")
}