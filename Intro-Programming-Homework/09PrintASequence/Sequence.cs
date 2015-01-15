using System;

// Write a program that prints the first 10 members of the sequence:  2, -3, 4, -5, 6, -7, ...

class Sequence
{
    static void Main(string[] args)
    {
        int negativeNumber = -3; // the negative numbers in the sequence
        for (int positiveNumber = 2; positiveNumber <= 10; positiveNumber = positiveNumber + 2)
        // using a for loop and adding 2 to the positive numbers until the number 10 is reached
        {
            Console.Write(positiveNumber + ", ");
            Console.Write(negativeNumber + ", ");
            negativeNumber = negativeNumber - 2; // subtracting 2 from the negative numbers
        }
    }
}
