using System;

// Write a program that reads 3 real numbers from the console and prints their sum.

class Sum
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of these three numbers is " + (firstNumber + secondNumber +thirdNumber));
    }
}
