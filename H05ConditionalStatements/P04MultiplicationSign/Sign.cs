//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class Sign
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        //check if any number is 0 in which case the result is 0
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("0");
        }

        //check if only one number is negative or all the numbers are negative
        //in which case the result is negative
        else if ((firstNumber < 0 && secondNumber > 0 && thirdNumber > 0) ||
            (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) ||
            (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0) ||
            (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0))
        {
            Console.WriteLine("-");
        }

        //if none of the above is true then the result is positive
        else
        {
            Console.WriteLine("+");
        }
    }
}