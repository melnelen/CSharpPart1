using System;
using System.IO;
using System.Numerics;

class P03
{
    static void Main(string[] args)
    {
        //StreamReader reader = new StreamReader("..\\..\\mytext03.txt");
        //Console.SetIn(reader);

        string myEnd = string.Empty;
        int i = 0;
        BigInteger check = 0;
        BigInteger numberResult = 1;
        BigInteger secondResult = 1;
        while (myEnd != "END" && i <= 10000)
        {
            BigInteger tempNumberResult = 1;
            BigInteger digitResult = 1;
            BigInteger tempDigitResult = 1;
            int tempDigit = 0;
            myEnd = Console.ReadLine().Trim();//read string
            bool isDigit = BigInteger.TryParse(myEnd, out check);
            if ((i % 2 == 0) && isDigit)
            {
                if (BigInteger.Parse(myEnd) == 0)
                {
                    tempNumberResult = 1;
                }
                else
                {
                    for (int digit = 0; digit < myEnd.Length; digit++)
                    {
                        tempDigit = int.Parse(myEnd[digit].ToString());
                        if (tempDigit == 0)
                        {
                            tempDigit = 1;
                        }
                        {
                            digitResult = tempDigitResult * tempDigit;
                        }
                        tempNumberResult *= digitResult;
                    }
                }
                if (i < 9)
                {
                    numberResult *= tempNumberResult;// result1
                }
                else
                {
                    secondResult *= tempNumberResult;// result2
                }
            }
            i++;
        }
        Console.WriteLine(numberResult);
        if (i >= 9)
        {
            Console.WriteLine(secondResult);
        }
    }
}