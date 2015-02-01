//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
using System.Linq;
using System.Numerics;

class Product
{
    static void Main(string[] args)
    {
        // Insert the numbers in an array
        int[] numbersInLine = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

        //initialize the products
        BigInteger oddProduct = 1;
        BigInteger evenProduct = 1;

        for (int i = 0; i < numbersInLine.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= numbersInLine[i]; 
            }
            else
            {
                evenProduct *= numbersInLine[i];
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product: {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd product: {0}", oddProduct);
            Console.WriteLine("even product: {0}", evenProduct);
        }
    }
}