using System;

// Write an expression that checks for given integer if its third digit from right-to-left is 7.

class ThirdDigit
{
    static void Main(string[] args)
    {
        int testNumber = 123789;
        if ((testNumber / 100) % 10 == 7)
        {
            Console.WriteLine("The third digit from right-to-left in this number is 7.");
        }
        else
        {
            Console.WriteLine("This number is not reliable ;p");
        }
    }
}
