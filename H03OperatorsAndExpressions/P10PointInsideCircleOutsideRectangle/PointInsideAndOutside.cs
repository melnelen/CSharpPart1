using System;

// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

class PointInsideAndOutside
{
    const float radius = 1.5F;
    const byte center = 1;
    static void Main(string[] args)
    {
        Console.Write("Please enter the first coordinate:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second coordinate:");
        double y = double.Parse(Console.ReadLine());
        double top = 1;
        double left = -1;
        double right = 5;
        double bottom = -1;
        if ((Math.Pow((center - x), 2) + Math.Pow((center - y), 2) <= radius * radius) &&
            !((y <= top) && (y >= bottom) && (x >= left) && (center <= right)))
        {
            Console.WriteLine("This point is inside the circle.");
        }
        else
        {
            Console.WriteLine("This point is somewhere else.");
        }
    }
}
