//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;

class OneToN
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a positive interger: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
                Console.Write("{0} ", i);
        }
        else
        {
            Console.Write("You entered a wrong number!");
        }
        Console.WriteLine();
    }
}