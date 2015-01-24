using System;

// Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your number:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the position of the bit you want to extract:");
        int p = int.Parse(Console.ReadLine());
        if ((n & (1 << p)) == 0)
        {
            Console.WriteLine("The bit on this position of this number is 0");
        }
        else
        {
            Console.WriteLine("The bit on this position of this number is 1");
        }
    }
}
