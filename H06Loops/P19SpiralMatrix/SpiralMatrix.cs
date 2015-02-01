//Problem 19.** Spiral Matrix

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral 
//like in the examples below.

//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7

using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 20)
        {
            int[,] matrix = new int[n, n];

            int row = 0;
            int col = 0;
            string dir = "right";
            int max = n * n;

            for (int i = 1; i <= max; i++)
            {
                if (dir == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    dir = "down";
                    col--;
                    row++;
                }
                if (dir == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    dir = "left";
                    row--;
                    col--;
                }
                if (dir == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    dir = "up";
                    col++;
                    row--;
                }
                if (dir == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    dir = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;
                if (dir == "right")
                {
                    col++;
                }
                if (dir == "down")
                {
                    row++;
                }
                if (dir == "left")
                {
                    col--;
                }
                if (dir == "up")
                {
                    row--;
                }
            }

            //print the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,-3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}