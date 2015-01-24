using System;

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoids
{
    static void Main(string[] args)
    {
        double a = 8.5;
        double b = 4.3;
        double h = 2.7;
        Console.WriteLine("The area of this trapezoid is " + ((a + b) * h / 2));
    }
}