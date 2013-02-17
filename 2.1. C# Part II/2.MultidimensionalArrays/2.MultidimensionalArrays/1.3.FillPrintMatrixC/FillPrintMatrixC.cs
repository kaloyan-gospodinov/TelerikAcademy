using System;
using System.Collections.Generic;
using System.Linq;


class FillPrintMatrixC
{
    static void Main()
    {
        Console.Write("Number of rows & columns= ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;

        for (int i = 0; i <= n-1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int row = n - i + j - 1;
                matrix[row, j] = number++;
            }
        }

        for (int i = n-2; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {   
                int row = i - j;
                int col = n - j - 1;
                matrix[row, col] = number++;
            }
        }


        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

