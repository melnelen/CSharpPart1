//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;

class BiggestOf3
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        //the commented code might or might not be there and the program
        //is still going to work correctly
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine("The biggest number is {0}.", firstNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            Console.WriteLine("The biggest number is {0}.", secondNumber);
        }
        else //if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
        {
            Console.WriteLine("The biggest number is {0}.", thirdNumber);
        }
        //else
        //{
        //    Console.WriteLine("Something somewhere went terribly wrong!");
        //}
    }
}