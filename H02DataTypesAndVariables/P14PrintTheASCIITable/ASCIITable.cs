using System;

// Find online more information about ASCII (American Standard Code for Information Interchange)
// and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
// Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
// Note: You may need to use for-loops (learn in Internet how).

class ASCIITable
{
    static void Main(string[] args)
    {
        for (int asciiChar = 0; asciiChar <= 255; asciiChar++)
        {
            Console.WriteLine("The {0} symbol in the ASCII Table is {1}", asciiChar, (char)asciiChar);
        }
    }
}
