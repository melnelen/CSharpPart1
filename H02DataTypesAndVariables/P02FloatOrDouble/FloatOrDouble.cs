using System;

// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
// 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

class FloatOrDouble
{
    static void Main(string[] args)
    {
        float justAFloatNumber = 12.345F;
        float justAnotherFolatNumber = 3456.091F;
        double justADoubleNumber = 34.567839023;
        double justAnotherDoubleNumber = 8923.1234857;
        Console.WriteLine("Here are the appropriate types for these numbers:");
        Console.WriteLine("{0} is a type {1}.", justAFloatNumber, justAFloatNumber.GetType());
        Console.WriteLine("{0} is a type {1}.", justAnotherFolatNumber, justAnotherFolatNumber.GetType());
        Console.WriteLine("{0} is a type {1}.", justADoubleNumber, justADoubleNumber.GetType());
        Console.WriteLine("{0} is a type {1}.", justAnotherDoubleNumber, justAnotherDoubleNumber.GetType());
    }
}
