using System;

// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

class BitwiseExtractBit3
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your favourite number:");
        uint justANumber = uint.Parse(Console.ReadLine());
        if (((justANumber >> 3) & 1) == 1)
        {
            Console.WriteLine("The third position in this number is 1");
        }
        else
        {
            Console.WriteLine("The third position in this number is 0");
        }
    }
}
