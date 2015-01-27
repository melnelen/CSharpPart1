using System;

/*
 * Write a program that reads 3 numbers:
 * integer a (0 <= a <= 500)
 * floating-point b
 * floating-point c
 * The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
 * The number a should be printed in hexadecimal, left aligned
 * Then the number a should be printed in binary form, padded with zeroes
 * The number b should be printed with 2 digits after the decimal point, right aligned
 * The number c should be printed with 3 digits after the decimal point, left aligned.
 */

class Formatting
{
    static void Main(string[] args)
    {
        Console.Write("Plese enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Plese enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Plese enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        // check if 0 <= a <= 500
        if ((a >= 0) && (a <= 500))
        {
            Console.WriteLine();
            Console.WriteLine("{0,-10:X} | {1} | {2,10:F2} | {3,-10:F3}",
                a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
        else
        {
            Console.WriteLine("The first number is less then 0 or more then 500!");
        }
    }
}
