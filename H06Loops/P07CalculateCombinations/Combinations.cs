//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: n! / (k! * (n-k)!) 
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

using System;
using System.Numerics;

class Combinations
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        if (k > 1 && k < n && n < 100)
        {
            int factN = n;
            int factK = k;
            for (int i = factN - 1; i > 0; i--)
            {
                if (factK > i)
                {
                    factK *= i;
                }
                factN *= i;
            }
            
            int factNK = n - k;
            for (int i = factNK - 1; i > 0; i--)
            {
            factNK *= i;
            }

            Console.WriteLine(factN / (factK * factNK));

            //using the myFactorial() method - the result is the same
            Console.WriteLine(myFactorial(n) / (myFactorial(k) * myFactorial(n - k)));
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
