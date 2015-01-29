//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, 
//corresponding to the English pronunciation.

using System;

class NumberAsWords
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number in the range [0…999]: ");
        int myNumber = int.Parse(Console.ReadLine());
        if (myNumber >= 0 && myNumber <= 999)
        {
            int digit = myNumber % 10;
            int tenth = (myNumber / 10) % 10;
            int hundredth = (myNumber / 100) % 10;

            if (myNumber >= 100)
            {
                if (tenth == 0 && digit == 0)
                {
                    Console.WriteLine(myDictionary(hundredth) + " hundred");
                }
                else if (tenth == 0 && digit != 0)
                {
                    Console.WriteLine(myDictionary(hundredth) + " hundred and " + myDictionary(digit));
                }
                else if (tenth == 1)
                {
                    Console.WriteLine(myDictionary(hundredth) + " hundred and " + myDictionary(digit + 10));
                }
                else if (tenth >= 2 && digit == 0)
                {
                    Console.WriteLine(myDictionary(hundredth) + " hundred and " + myDictionary(tenth * 10));
                }
                else if (tenth >= 2 && digit != 0)
                {
                    Console.WriteLine(myDictionary(hundredth) + " hundred and " + myDictionary(tenth * 10) + " " + myDictionary(digit));
                }
            }
            else if (myNumber >= 20)
            {
                if (digit == 0)
                {
                    Console.WriteLine(myDictionary(tenth * 10));
                }
                else
                {
                    Console.WriteLine(myDictionary(tenth * 10) + " " + myDictionary(digit));
                }
            }
            else if (myNumber >= 10)
            {
                Console.WriteLine(myDictionary(digit + 10));
            }
            else if (myNumber < 10 && myNumber > 0)
            {
                Console.WriteLine(myDictionary(digit));
            }
        }
        else
        {
            Console.WriteLine("invalid number!");
        }
    }

    //Dictionary with the words to use
    static string myDictionary(int myNumber)
    {
        switch (myNumber)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            case 20: return "twenty";
            case 30: return "thirty";
            case 40: return "forty";
            case 50: return "fifty";
            case 60: return "sixty";
            case 70: return "seventy";
            case 80: return "eight";
            case 90: return "ninety";
            default: return "invalid number!";
        }
    }
}