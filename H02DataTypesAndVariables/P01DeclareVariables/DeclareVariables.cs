using System;

// Declare five variables choosing for each of them the most appropriate of the types
// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

class DeclareVariables
{
    static void Main(string[] args)
    {
        byte myByte = 97;
        sbyte mySByte = -115;
        short myShort = -10000;
        ushort myUShort = 52130;
        int myInt = 4825932;
        Console.WriteLine("Here are the appropriate types for these numbers:");
        Console.WriteLine("{0} is a type {1}.", myByte, myByte.GetType());
        Console.WriteLine("{0} is a type {1}.", mySByte, mySByte.GetType());
        Console.WriteLine("{0} is a type {1}.", myShort, myShort.GetType());
        Console.WriteLine("{0} is a type {1}.", myUShort, myUShort.GetType());
        Console.WriteLine("{0} is a type {1}.", myInt, myInt.GetType());
    }
}
