using System;

// Write a program that reads a number n and prints on the console
// the first n members of the Fibonacci sequence (at a single line,
// separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
// Note: You may need to learn how to use loops.

class Fibonacci
{
    static void Main(string[] args)
    {
        Console.Write("Please enter how many Fibonacci numbers you would like to view: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 3)
        {
            int firstNumber = 0; // the first Fibonacci number
            int secondNumber = 1; // the second Fibonacci number
            Console.Write(firstNumber + ", ");
            Console.Write(secondNumber + ", ");

            // we need to add the first two Fibonacci numbers to get the next one
            // and the do this for the next n - 2 (excluding the first two numbers from the count)
            // numbers to get every next number
            for (int i = 1; i <= (n - 2); i++)
            {
                int nextNumber = (firstNumber + secondNumber);
                Console.Write(nextNumber + ", ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
        else
        {
            Console.WriteLine("Please enter a bigger number!");
        }
    }
}
