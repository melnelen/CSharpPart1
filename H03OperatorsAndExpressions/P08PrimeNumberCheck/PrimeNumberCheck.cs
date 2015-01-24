using System;

// Write an expression that checks if given positive integer number n (n <= 100) is prime 
// (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is a prime number: ");
        int numberToCheck = int.Parse(Console.ReadLine());
        if ((numberToCheck > 1) && (numberToCheck <= 100) && (numberToCheck % numberToCheck == 0) && (numberToCheck % 1 == 0))
        {
            Console.WriteLine("This is a prime number.");
        }
        else
        {
            Console.WriteLine("We don't need this number.");
        }
    }
}
