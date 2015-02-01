//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n 
//and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeOneToN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //create an array of random numbers
        int[] numbers = new int[n];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, n + 1);
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}