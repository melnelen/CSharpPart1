using System;

// Write a program that enters a number n and after that enters
// more n numbers and calculates and prints their sum. 
// Note: You may need to use a for-loop.

class SumOfN
{
    static void Main(string[] args)
    {
        Console.Write("Please enter how many numbers you would like to sum: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter {0} numbers:", n);

        // adding each number from the console to the one before 
        // and saving the result in the variable sum
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum of these {0} numbers is {1}", n, sum);
    }
}
