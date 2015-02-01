//Problem 18.* Trailing Zeroes in N!

//Write a program that calculates with how many zeroes 
//the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factN = myFactorial(n);
        int count = 0;
        while (factN % 10 == 0)
        {
            factN /= 10;
            count++;
        }
        Console.WriteLine(count);
    }

    //calculate the factorial
    static BigInteger myFactorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            BigInteger fact = x;
            for (int i = x - 1; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}