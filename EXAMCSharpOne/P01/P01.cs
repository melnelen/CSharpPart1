using System;
using System.IO;
using System.Numerics;

class P01
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\mytext01.txt");
        //Console.SetIn(reader);
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long max = 0;
        long min = 0;
        double mean = (double)((a + b + c) / 3.0);

        if (a >= b && a >= c)
        {
            max = a;
        }
        else if (b >= a && b >= c)
        {
            max = b;
        }
        else if (c >= a && c >= b)
        {
            max = c;
        }

        if (a <= b && a <= c)
        {
            min = a;
        }
        else if (b <= a && b <= c)
        {
            min = b;
        }
        else if (c <= a && c <= b)
        {
            min = c;
        }

        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine("{0:F3}", mean);

    }
}