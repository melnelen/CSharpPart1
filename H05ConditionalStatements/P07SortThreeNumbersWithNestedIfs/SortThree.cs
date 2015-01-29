//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;

class SortThree
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        //this method is really fast if the numbers are already in order
        Console.Write("The numbers sorted in descending order are: ");

        //if firstNumber is the biggest
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Console.Write(firstNumber + ", ");

            // if secondNumber is the second biggest
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber + ", " + thirdNumber + ".");
            }

            // if thirdNumber is the second biggest
            else
            {
                Console.WriteLine(thirdNumber + ", " + secondNumber + ".");
            }
        }

        // if firstNumber is not the biggest
        else
        {
            //if secondNumber is the biggest
            if (secondNumber >= thirdNumber)
            {
                Console.Write(secondNumber + ", ");

                //if firstNumber is the second biggest
                if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine(firstNumber + ", " + thirdNumber + "."); 
                }

                //if thirdNumber is the second biggest
                else
                {
                    Console.WriteLine(thirdNumber + ", " + firstNumber + ".");
                }
            }

            //if thirdNumber is the biggest
            else
            {
                Console.Write(thirdNumber + ", ");

                //if firstNumber is the second biggest
                if (firstNumber >= secondNumber)
                {
                    Console.WriteLine(firstNumber + ", " + secondNumber + ".");
                }

                //if secondNumber is the second biggest
                else
                {
                    Console.WriteLine(secondNumber + ", " + firstNumber + ".");
                }
            }
        }

        //and the less interesting way to do this:

        //if (firstNumber < secondNumber)
        //{
        //    firstNumber = firstNumber + secondNumber;
        //    secondNumber = firstNumber - secondNumber;
        //    firstNumber = firstNumber - secondNumber;

        //    if (firstNumber < thirdNumber)
        //    {
        //        firstNumber = firstNumber + thirdNumber;
        //        thirdNumber = firstNumber - thirdNumber;
        //        firstNumber = firstNumber - thirdNumber;

        //        if (secondNumber <= thirdNumber)
        //        {
        //            secondNumber = secondNumber + thirdNumber;
        //            thirdNumber = secondNumber - thirdNumber;
        //            secondNumber = secondNumber - thirdNumber;
        //        }
        //    }
        //}
        //else if (firstNumber < thirdNumber)
        //{
        //    firstNumber = firstNumber + thirdNumber;
        //    thirdNumber = firstNumber - thirdNumber;
        //    firstNumber = firstNumber - thirdNumber;

        //    if (secondNumber <= thirdNumber)
        //    {
        //        secondNumber = secondNumber + thirdNumber;
        //        thirdNumber = secondNumber - thirdNumber;
        //        secondNumber = secondNumber - thirdNumber;
        //    }
        //}

        //Console.WriteLine("The numbers sorted in descending order are: {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);

        //the difference is that in the first method we don't change the values of the variables
        //while in the second method we might change the values of all the variables
    }
}