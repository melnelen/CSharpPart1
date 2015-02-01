//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: 
//catalan-formula: fact(2 * n) / (fact(n + 1) * fact(n))
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 0 && n <=100)
        {
            Console.WriteLine(myFactorial(2 * n) / (myFactorial(n + 1) * myFactorial(n)));
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
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