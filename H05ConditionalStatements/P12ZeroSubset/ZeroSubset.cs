//Problem 12.* Zero Subset

//We are given 5 integer numbers. Write firstNumber program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not firstNumber problem.
//Hint: you may check for zero each of the 31 subsets with 31 if statements.

using System;

class ZeroSubset
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());

        bool zSubset = false;

        if (firstNumber + secondNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, secondNumber);
            zSubset = true;
        }
        if (firstNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, thirdNumber);
            zSubset = true;
        }
        if (firstNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, fourthNumber);
            zSubset = true;
        }
        if (firstNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", firstNumber, fifthNumber);
            zSubset = true;
        }
        if (secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, thirdNumber);
            zSubset = true;
        }
        if (secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, fourthNumber);
            zSubset = true;
        }
        if (secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", secondNumber, fifthNumber);
            zSubset = true;
        }
        if (thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNumber, fourthNumber);
            zSubset = true;
        }
        if (thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", thirdNumber, fifthNumber);
            zSubset = true;
        }
        if (fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} = 0", fourthNumber, fifthNumber);
            zSubset = true;
        }
        if (firstNumber + secondNumber + thirdNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, thirdNumber);
            zSubset = true;
        }
        if (firstNumber + secondNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fourthNumber);
            zSubset = true;
        }
        if (firstNumber + secondNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, fifthNumber);
            zSubset = true;
        }
        if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fourthNumber);
            zSubset = true;
        }
        if (firstNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fifthNumber);
            zSubset = true;
        }
        if (firstNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, fourthNumber, fifthNumber);
            zSubset = true;
        }
        if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fourthNumber);
            zSubset = true;
        }
        if (secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, fourthNumber, fifthNumber);
            zSubset = true;
        }
        if (secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fifthNumber);
            zSubset = true;
        }
        if (thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNumber, fourthNumber, fifthNumber);
            zSubset = true;
        }
        if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber);
            zSubset = true;
        }
        if (firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fifthNumber);
            zSubset = true;
        }
        if (firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, fourthNumber, fifthNumber);
            zSubset = true;
        }
        if (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, thirdNumber, fourthNumber, fifthNumber);
            zSubset = true;
        }
        if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", secondNumber, thirdNumber, fourthNumber, fifthNumber);
            zSubset = true;
        }
        if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
            zSubset = true;
        }

        if (!zSubset)
        {
            Console.WriteLine("No zero subset.");
        }
    }
}