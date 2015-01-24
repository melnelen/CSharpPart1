using System;

// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

class Divide
{
    static void Main(string[] args)
    {
        int megaInt = 35;
        if ((megaInt != 0) && (megaInt % 5 == 0) && (megaInt % 7 == 0))
        {
            Console.WriteLine("This number can be divided by 5 and 7 at the same time.");
        }
        else
        {
            Console.WriteLine("This number s\u002Acks!");
        }
    }
}
