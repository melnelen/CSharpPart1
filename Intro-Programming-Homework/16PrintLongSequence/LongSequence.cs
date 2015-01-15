using System;

// Write a program that prints the first 1000 members of the sequence:  2, -3, 4, -5, 6, -7, ...
// You might need to learn how to use loops in C# (search in Internet).

class LongSequence
{
    static void Main(string[] args)
    {
        int negativeNumber = -3; // the negative numbers in the sequence
        for (int positiveNumber = 2; positiveNumber <= 1000; positiveNumber = positiveNumber + 2)
        // using a for loop and adding 2 to the positive numbers until the number 1000 is reached
        {
            Console.Write(positiveNumber + ", ");
            Console.Write(negativeNumber + ", ");
            negativeNumber = negativeNumber - 2; // subtracting 2 from the negative numbers
        }
    }
}
