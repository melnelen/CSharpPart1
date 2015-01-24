using System;

// Write a program that exchanges bits {p, p+1, …, p+k-1}
// with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
// The first and the second sequence of bits may not overlap.

class BitExchangeAdvanced
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the unsigned integer number:");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Please enter the start position of the first bit sequence:");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("Please enter the start position of the second bit sequence:");
        byte q = byte.Parse(Console.ReadLine());
        Console.Write("Please enter the lenght of the sequence:");
        byte k = byte.Parse(Console.ReadLine());
        if (p + k >= 32)
        {
            Console.WriteLine("This number is out of range!");
        }
        else if (p < q && ((p + q) < k))
        {
            Console.WriteLine("The first and the second sequence of bits are overlapping!");
        }
        else
        {
            Console.Write("The initial binary representation is:");
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            //Swap bits p with bits q
            n = ((~(((uint)Math.Pow(2, k) - 1) << q | 
                ((uint)Math.Pow(2, k) - 1) << p)) & n) | 
                (((n & (((uint)Math.Pow(2, k) - 1) << p)) << (Math.Abs(p - q))) | 
                ((n & (((uint)Math.Pow(2, k) - 1) << q)) >> (Math.Abs(p - q))));

            Console.Write("The new binary representation is:");
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("The new number is: {0}", n);
        }
    }
}
