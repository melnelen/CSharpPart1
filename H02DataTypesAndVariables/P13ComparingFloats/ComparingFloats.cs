using System;

// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
// Note: Two floating-point numbers a and b cannot be compared directly by a == b
// because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal 
// if they are more closely to each other than a fixed constant eps.

class ComparingFloats
{
    static void Main(string[] args)
    {
        const float eps = 0.000001F;
        double justSomeNumber = 1.000001;
        double justAnotherNumber = 1.000002;
        if (Math.Abs(justSomeNumber - justAnotherNumber) < eps)
        {
            Console.WriteLine("The two numbers are equal!");
        }
        else
        {
            Console.WriteLine("The two numbers are not equal!");
        }
    }
}
