using System;
using System.Linq;

// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0.

class FourDigit
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a four digit number:");
        int[] myFourDigitNumber = Console.ReadLine().Trim().ToCharArray().Select(x => Int32.Parse(x.ToString())).ToArray();
        if ((myFourDigitNumber[0] != 0) && (myFourDigitNumber.Length == 4))
        {
            Console.WriteLine("The sum of the digits of this number is " + 
                (myFourDigitNumber[0] + myFourDigitNumber[1] + myFourDigitNumber[2] + myFourDigitNumber[3]));
            Console.WriteLine("This number in reversed order is " +
                myFourDigitNumber[3] + myFourDigitNumber[2] + myFourDigitNumber[1] + myFourDigitNumber[0]);
            Console.WriteLine("When we put the last digit in the first position the number is " +
                myFourDigitNumber[3] + myFourDigitNumber[0] + myFourDigitNumber[1] + myFourDigitNumber[2]);
            Console.WriteLine("When we exchage the second and the thord digit the number is " +
                myFourDigitNumber[0] + myFourDigitNumber[2] + myFourDigitNumber[1] + myFourDigitNumber[3]);
        }
        else
        {
            Console.WriteLine("This number s\u002Acks!");
        }
    }
}
