//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        long decimalN = long.Parse(Console.ReadLine());
        string binaryN = "";

        do
        {
            if (decimalN % 2 == 0)
            {
                binaryN = "0" + binaryN;
            }
            else
            {
                binaryN = "1" + binaryN;
            }
            decimalN = decimalN / 2;
        } while (decimalN > 0);

        Console.WriteLine(binaryN);
    }
}