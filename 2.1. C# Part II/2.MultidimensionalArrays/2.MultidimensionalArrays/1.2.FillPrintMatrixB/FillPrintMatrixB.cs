using System;
using System.Collections.Generic;
using System.Linq;


class FillPrintMatrixB
{
    static void Main()
    {
        Console.Write("Number of rows & columns= ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int number = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = number++;
                }
            }

            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = number++;
                }
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

