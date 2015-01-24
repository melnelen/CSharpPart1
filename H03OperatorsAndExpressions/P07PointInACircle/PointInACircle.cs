using System;

// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

class PointInACircle
{
    const byte r = 2;
    static void Main(string[] args)
    {
        Console.Write("Please enter the first coordinate:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second coordinate:");
        double y = double.Parse(Console.ReadLine());
        if (((x * x) + (y * y)) <= (r * r))
        {
            Console.WriteLine("This point is inside the circle.");
        }
        else
        {
            Console.WriteLine("This point is somewhere else.");
        }
    }
}
