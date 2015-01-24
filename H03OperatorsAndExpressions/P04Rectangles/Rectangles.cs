using System;

// Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Rectangles
{
    static void Main(string[] args)
    {
        double widht = 3;
        double hight = 4;
        Console.WriteLine("The perimeter of this rectangle is {0}", ((widht * 2) + (hight * 2)));
        Console.WriteLine("The area of this rectange is {0}", (widht * hight));
    }
}
