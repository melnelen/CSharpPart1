//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        long decimalN = long.Parse(Console.ReadLine());

        long tempN = decimalN;
        string tempHexN = String.Empty;
        long rem = 0;
        while (tempN > 0)
        {
            rem = tempN % 16;
            tempN /= 16;
            switch (rem)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: tempHexN += rem; break;
                case 10: tempHexN += 'A'; break;
                case 11: tempHexN += 'B'; break;
                case 12: tempHexN += 'C'; break;
                case 13: tempHexN += 'D'; break;
                case 14: tempHexN += 'E'; break;
                case 15: tempHexN += 'F'; break;
                default: tempHexN += 0; break;
            }
        }

        string hexNumber = String.Empty;
        for (int i = tempHexN.Length - 1; i >= 0; i--)
        {
            hexNumber += tempHexN[i];
        }
        Console.WriteLine(hexNumber);
    }
}