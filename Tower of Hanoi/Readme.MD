Tower of Hanoi
===============

This project provides a recursive solution of the classic [Tower of Hanoi](https://en.wikipedia.org/wiki/Tower_of_Hanoi) problem.

The solution to the Towers of Hanoi problem can be expressed recursively using the notion of subtrees. Suppose you want to move all the disks from a source tower (say ***S***) to a destination tower (say ***D***). You have an intermediate tower available (say ***I***). Assume there are n disks on tower ***S***. The algorithms is as follows:

1. Move the subtree consisting of the top n-1 disks from ***S*** to ***I***.
2. Move the remaining (*largest*) disk from ***S*** to ***D***.
3. Move the subtree from ***I*** to ***D***. 