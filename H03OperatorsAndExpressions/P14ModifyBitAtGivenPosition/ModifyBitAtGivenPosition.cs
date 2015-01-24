using System;

// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to
// hold the value v at the position p from the binary representation of n
// while preserving all other bits in n.

class ModifyBitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your number:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the position of the bit you want to extract:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter the value you want to put at this position (0 or 1):");
        byte v = byte.Parse(Console.ReadLine());
        int mask = 1 << p;
        if (v == 1)
        {
            n = n | mask;
        }
        else if ((n & mask) == mask)
            {
                n = n ^ mask;
            }
        Console.WriteLine("The value of the number after it has been moified is {0}", n);
    }
}
