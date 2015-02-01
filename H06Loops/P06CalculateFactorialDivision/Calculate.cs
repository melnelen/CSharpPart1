//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class Calculate
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        if (k > 1 && k < n && n < 100)
        {
            //calculate n! (because n > k)
            for (int i = n - 1 ; i > 0; i--)
            {
                //calculate k! (because k < n)
                if (k > i)
                {
                    k *= i;
                }

                n *= i;
            }

            Console.WriteLine(n / k);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}