//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestOfFive
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        //using only four if statements :)

        //the commented code might or might not be there and the program
        //is still going to work correctly
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber && 
            firstNumber >= fourthNumber && firstNumber >= fifthNumber)
        {
            Console.WriteLine("The biggest number is {0}.", firstNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber &&
            secondNumber >= fourthNumber && secondNumber >= fifthNumber)
        {
            Console.WriteLine("The biggest number is {0}.", secondNumber);
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber &&
            thirdNumber >= fourthNumber && thirdNumber >= fifthNumber)
        {
            Console.WriteLine("The biggest number is {0}.", thirdNumber);
        }
        else if (fourthNumber >= firstNumber && fourthNumber >= secondNumber &&
            fourthNumber >= thirdNumber && fourthNumber >= fifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", fourthNumber);
        }
        else //if (fifthNumber >= firstNumber && fifthNumber >= secondNumber &&
            //fifthNumber >= thirdNumber && fifthNumber >= fourthNumber)
        {
            Console.WriteLine("The biggest number is {0}.", fifthNumber);
        }
        //else
        //{
        //    Console.WriteLine("Something somewhere went terribly wrong!");
        //}
    }
}