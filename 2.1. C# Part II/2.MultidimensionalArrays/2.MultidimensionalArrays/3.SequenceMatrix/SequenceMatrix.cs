using System;
using System.Collections.Generic;
using System.Linq;

class SequenceMatrix
{
    static void Main()
    {
        Console.Write("Number of rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Number of columns = ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                int element = int.Parse(Console.ReadLine());
                matrix[row, col] = element;
            }
        }

        


        for (int row = 0; row < row; row++)
        {
            for (int col = 0; col < col; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

