//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) 
//of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;
using System.Collections.Generic;

class GCD
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (b < a)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        if (a != 0 && b != 0)
        {
            if (a < 0)
            {
                a *= (-1);
            }
            if (b < 0)
            {
                b *= (-1);
            }
            List<int> minNumberDivisors = new List<int>();

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    minNumberDivisors.Add(i);
                }
            }

            int gcd = 0;
            for (int i = minNumberDivisors.Count - 1; i >= 0; i--)
            {
                if (b % minNumberDivisors[i] == 0)
                {
                    gcd = minNumberDivisors[i];
                    break;
                }
            }

            Console.WriteLine(gcd);
        }
    }
}