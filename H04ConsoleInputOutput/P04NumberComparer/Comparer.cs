using System;

// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

class Comparer
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        // using Math.Max to extract the bigger number
        double bigNumber = Math.Max(firstNumber, secondNumber);

        Console.WriteLine("The bigger of these two numbers is {0}", bigNumber);
    }
}
