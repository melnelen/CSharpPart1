using System;

// Declare two integer variables a and b and assign them with 5 and 10
// and after that exchange their values by using some programming logic.
// Print the variable values before and after the exchange.

class Exchange
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The value of a before the exchage is: {0}", a);
        Console.WriteLine("The value of b before the exchage is: {0}", b);
        if (a < b)
        {
            int x = a;
            a = b;
            b = x;
            Console.WriteLine("The valuse of a after the exchange is: {0}", a);
            Console.WriteLine("The valuse of b after the exchange is: {0}", b);
        }
        else
        {
            Console.WriteLine("Something somewhere went terribly wrong!");
        }
    }
}