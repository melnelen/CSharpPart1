using System;

// Write a program that reads two positive integer numbers and prints
// how many numbers p exist between them such that the reminder
// of the division by 5 is 0.

class NumbersInInterval
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int p = 0; // start the count
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                p++; // increnemt the count only if the number is dividable to 5
            }
        }

        Console.WriteLine("The numbers between {0} and {1} that have a reminder 0 when divided by 5 are {2}.", 
            firstNumber, secondNumber, p);
    }
}