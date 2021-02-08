package main

import (
	"fmt"
	"time"
)

func send(a, c chan int) {
	doWork := true
	for doWork{
		select {
		case b := <-a:
			fmt.Println(b)
		case <-c:
			doWork = false
		default:
			time.Sleep(1 * time.Second)
			fmt.Println("waiting...")
		}
	}
	a <- 0
	fmt.Println("DONE")
}

func main() {
	a := make(chan int)
	c := make(chan int)
	go send(a, c)
	time.Sleep(3 * time.Second)
	a <- 0
	time.Sleep(2 * time.Second)
	c <- 0
	fmt.Println(<-a)
}
