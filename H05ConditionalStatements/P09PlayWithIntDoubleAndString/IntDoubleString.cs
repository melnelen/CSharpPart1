//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class IntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        byte myChoise = byte.Parse(Console.ReadLine());

        switch (myChoise)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int myInt = int.Parse(Console.ReadLine());
                Console.WriteLine(++myInt);
                break;
            case 2:
                Console.Write("Plaese enter a double: ");
                double myDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(++myDouble);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string myString = Console.ReadLine();
                Console.WriteLine(myString + "\u002A");
                break;
            default:
                Console.WriteLine("You are a looser!");
                break;
        }
    }
}