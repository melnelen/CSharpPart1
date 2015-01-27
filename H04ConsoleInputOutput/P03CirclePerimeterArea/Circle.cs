using System;

// Write a program that reads the radius r of a circle and prints its 
// perimeter and area formatted with 2 digits after the decimal point.

class Circle
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());
        double circleArea = (r * r) * Math.PI;
        double circlePerimeter = (Math.PI * r) * 2;

        Console.WriteLine("The area of the circle is {0:F2}", circleArea);
        Console.WriteLine("The perimeter of the circle is {0:F2}", circlePerimeter);
    }
}
