package main

import (
	"fmt"
)

func sender(numb int, toReceiver, exitR, exitP chan int) {
	doWork := true
	for doWork{
		select {
		case <-exitR:
			doWork = false
		default:
			toReceiver <- numb
			numb++
		}
	}

	exitP <- 0
	exitP <- 0
	return
}

func receiver(fromSender, toPrinter1, toPrinter2, exitS chan int) {
	counter := 0
	for counter < 20 {
		select {
		case numb := <-fromSender:
			if numb % 2 != 0{
				counter++
				toPrinter1 <- numb
			} else {
				toPrinter2 <- numb
				counter++
			}
		default:

		}
	}

	exitS <- 0
	exitS <- 0
	return
}

func printer(fromReceiver, exit, fin chan int, number int) {
	var a = make([]int, 0)
	for {
		select {
		case numb := <-fromReceiver:
			a =  append(a, numb)
			fmt.Println(fmt.Sprintf("Printer %v: number: %v, count: %v", number, numb, len(a)))
		case <-exit:
			fmt.Println(fmt.Sprintf("\nPrinter %v: whole array: %v\n", number, a))
			fin <- 0

			break
		}
	}

	return
}

func main() {
	toReceiver := make(chan int)
	toPrinter1 := make(chan int)
	toPrinter2 := make(chan int)
	exitP := make(chan int)
	exitR := make(chan int)
	fin := make(chan int)

	go sender(0, toReceiver, exitR, exitP)
	go sender(11, toReceiver, exitR, exitP)

	go receiver(toReceiver, toPrinter1, toPrinter2, exitR)

	go printer(toPrinter1, exitP, fin, 1)
	go printer(toPrinter2, exitP, fin, 2)

	<-fin
	<-fin

	fmt.Println("Jobs done")
}
