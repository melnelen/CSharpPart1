using System;
using System.IO;

class P02
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\mytext02.txt");
        //Console.SetIn(reader);

        byte SECRET = byte.Parse(Console.ReadLine());
        int symbol = Console.Read();

        double modSymbol = 0;
        double result = 0;

        for (int i = 0; symbol != '@'; i++)
        {
            if ((symbol >= 65 && symbol <= 90) || (symbol >= 97 && symbol <= 122))
            {
                modSymbol = symbol * SECRET + 1000;
            }
            else if (symbol >= 48 && symbol <= 57)
            {
                modSymbol = symbol + SECRET + 500;
            }
            else
            {
                modSymbol = symbol - SECRET;
            }

            if (i % 2 == 0)
            {
                result = Math.Round((modSymbol / 100), 2);
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                result = modSymbol * 100;
                Console.WriteLine(result);
            }
            symbol = Console.Read();
        }
    }
}