using System;

// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

class NullValues
{
    static void Main(string[] args)
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("The value of the int variable is: {0}", nullInt);
        Console.WriteLine("The value of the double variable is: {0}", nullDouble);
        nullInt += 123;
        nullDouble += 123.45;
        Console.WriteLine("The value of the changed int variable is: {0}", nullInt);
        Console.WriteLine("The value of the changed double variable is: {0}", nullDouble);
    }
}
