using System;

// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//    ©
// 
//   © ©
// 
//  ©   ©
// 
// © © © ©
// Note: The © symbol may be displayed incorrectly at the console so you may need to change
// the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
// Note: Under old versions of Windows the © symbol may still be displayed incorrectly,
// regardless of how much effort you put to fix it.

class CoprTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // The font of the console needs to be chaged to Lucida Console
        // The Unicode code for the copyright symbol is \u00A9
        char copr = '\u00A9';
        Console.WriteLine("   {0}\n", copr);
        Console.WriteLine("  {0} {0}\n", copr);
        Console.WriteLine(" {0}   {0}\n", copr);
        Console.WriteLine("{0} {0} {0} {0}\n", copr);
    }
}
