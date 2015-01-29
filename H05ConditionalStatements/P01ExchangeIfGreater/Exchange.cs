//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values
//if the first one is greater than the second one.
//As a result print the values a and b, separated by a space.

using System;

class Exchange
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            double x = firstNumber;
            firstNumber = secondNumber;
            secondNumber = x;
        }

        Console.WriteLine("The right order for this two numbers is: {0} {1}", firstNumber, secondNumber);
    }
}