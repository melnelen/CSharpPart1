using System;

// Write a program that reads the coefficients a, b and c of a quadratic equation
// ax2 + bx + c = 0 and solves it (prints its real roots).

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the first coeficient: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second coeficient: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third coeficient: ");
        double c = double.Parse(Console.ReadLine());

        double D = Math.Pow(b, 2) - (4 * a * c); //D = b2 – 4ac

        if (D < 0)
        {
            Console.WriteLine("There are no real roots!");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x);
        }
        else
        {
            double x1 = (-b - Math.Sqrt(D)) / (2 * a);
            double x2 = (-b + Math.Sqrt(D)) / (2 * a);

            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);
        }
    }
}