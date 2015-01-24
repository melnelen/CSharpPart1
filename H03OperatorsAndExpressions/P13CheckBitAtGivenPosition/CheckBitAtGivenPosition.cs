using System;

// Write a Boolean expression that returns if the bit at position p
// (counting from 0, starting from the right)
// in given integer number n, has value of 1.

class CheckBitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your number:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the position of the bit you want to extract:");
        int p = int.Parse(Console.ReadLine());
        if ((n & (1 << p)) == 1)
        {
            Console.WriteLine("The bit on this position of this number is 1");
        }
        else
        {
            Console.WriteLine("The bit on this position of this number is not 1");
        }
    }
}
