using System;

// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

class BitsExchange
{
    static void Main(string[] args)
    {
        Console.Write("Enter the unsigned integer number:");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("The initial binary representation is:");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        //Swap bits 3, 4 and 5 with 24, 25 and 26
        n = ((~(7U << 24 | 7U << 3)) & n) |
            (((n & (7U << 3)) << 21) |
            ((n & (7U << 24)) >> 21));

        Console.Write("The new binary representation is:");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("The new number is: {0}", n);
    }
}