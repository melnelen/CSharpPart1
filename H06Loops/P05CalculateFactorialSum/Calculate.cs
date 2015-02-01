//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, 
//calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;

class Calculate
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double S = 1; //initialize the sum
        for (int i = 1; i <= n; i++)
        {
            S += (double)myFactorial(i) / (double)myPowLoop(x, i);
        }
        Console.WriteLine("{0:F5}", S);
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

    //calculate the pow - much faster then Math.Pow()
    static BigInteger myPowLoop(int m, int n)
    {
        BigInteger pow = m;
        for (int i = 1; i < n; i++)
        {
            pow *= m;
        }
        return pow;
    }
}