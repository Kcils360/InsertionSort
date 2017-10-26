# InsertionSort

https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-6.php

Resource to learn what it was

https://gist.github.com/JerryBian/3214156

Resource to learn the code

I first had to learn what an insertion sort was.  once I understood what the final product should look like I searched for some code that I could understand how it was working.

It requires 2 loops, the first for loop starts at position [0] and works up through the array.  at each position, the second loop checks the next item against the current first loop item, and subsequently back down to [0] as the first loop progresses forward.  This moves each item backward from its current position toward [0] to a point where it is higher than the one before it and lower than the one after it.

The final foreach loop is for printing the result to the console.

# MergeSort

http://www.geeksforgeeks.org/merge-sort/

Resource to learn what it was

http://www.sanfoundry.com/csharp-program-merge-sort/

Resource to learn the code

First I looked up how a merge sort works.  After I figured that out, I searched for a code that I could understand and then adapt for myself. 
The merge sort relies on a nested if statemnet inside of a while loop to handle to merge portion.  First, we split an array in half, then the halves in half, so on untill all integers have been split apart.  Then using 2 while loops in the if statement we reorder them from smallest to largest.

# RadixSort

http://www.geeksforgeeks.org/radix-sort/

It took a bit to understand what happens with a Radix sort.  I had to look at several tutorials and a few gifs to grasp what happens.  I went into the code with a pretty basic understanding of the basic movement of values, that is sorts by 1s, then 10s, then 100 etc. But I wasn't sure HOW it did it.  I was able to get code into the IDE and put a debug point on the final for loop in the count body, that's when I finally grasped it.  I was able to watch the "output array" sort step by step. Cool!
