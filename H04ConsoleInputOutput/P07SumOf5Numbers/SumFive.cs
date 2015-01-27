using System;
using System.Linq;

// Write a program that enters 5 numbersInLine (given in a single line, separated by a space),
// calculates and prints their sum.

class SumFive
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the five numbers separated by a space: ");

        // Insert the numbers in an array
        double[] numbersInLine = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x)).ToArray();

        Console.WriteLine("The sum is {0:F2}.", numbersInLine.Sum());
    }
}
