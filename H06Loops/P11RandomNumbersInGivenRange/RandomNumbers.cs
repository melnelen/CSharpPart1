//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max)
//and prints n random numbers in the range [min...max].

using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        if (min != max)
        {
            //if min > max exchange values
            if (min > max)
            {
                min = min + max;
                max = min - max;
                min = min - max;
            }

            //create an array of random numbers
            int[] numbers = new int[n];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}