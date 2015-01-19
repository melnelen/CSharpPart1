using System;

// Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
// Use Windows Calculator to find its hexadecimal representation.
// Print the variable and ensure that the result is 254.

class VarInHex
{
    static void Main(string[] args)
    {
        int myHex = 0xFE;
        if (myHex == 254) // checking if the value of the variable is 254
        {
            Console.WriteLine("The decimal representation of the hexadecimal number FE is: {0}", myHex);
        }
        else
        {
            Console.WriteLine("Something somewhere went terribly wrong!");
        }
    }
}
