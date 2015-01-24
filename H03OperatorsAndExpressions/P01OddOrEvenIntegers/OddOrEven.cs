using System;

// Write an expression that checks if given integer is odd or even.

class OddOrEven
{
    static void Main(string[] args)
    {
        int oddEven = 5;
        if (oddEven % 2 == 0)
        {
            Console.WriteLine("This number is even.");
        }
        else
        {
            Console.WriteLine("This number is odd.");
        }
    }
}
