//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: 
//`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” 
//if it is a valid card sign or “no” otherwise. Examples:

using System;

class Check
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a card sign: ");
        string cardSign = Console.ReadLine();

        if (cardSign == "2" || cardSign == "3" || cardSign == "4" || cardSign == "5" || cardSign == "6" || 
            cardSign == "7" || cardSign == "8" || cardSign == "9" || cardSign == "10" || cardSign == "J" ||
            cardSign == "Q" || cardSign == "K" || cardSign == "A")
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}