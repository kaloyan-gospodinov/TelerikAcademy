using System;

class IntSpiralTwenty
{
    
    static void Main()
    {
        Console.Write("Enter a integer number smaller than 20: ");
        string stringNumber = Console.ReadLine();
        int matrixSize = int.Parse(stringNumber);
        int[,] matrix = new int[matrixSize, matrixSize];
        int num = 1;

        if (matrixSize < 20)
        {
            for (int depth = 0; depth < matrixSize / 2 + matrixSize % 2; depth++)
            {
                for (int col = depth; col < matrixSize - depth; col++)
                {
                    matrix[depth, col] = num;
                    num++;
                }

                for (int row = 1 + depth; row < matrixSize - depth; row++)
                {
                    matrix[row, matrixSize - 1 - depth] = num;
                    num++;
                }

                for (int col = matrixSize - 2 - depth; col >= depth; col--)
                {
                    matrix[matrixSize - 1 - depth, col] = num;
                    num++;
                }

                for (int row = matrixSize - 2 - depth; row > depth; row--)
                {
                    matrix[row, depth] = num;
                    num++;
                }
            }
            Matrix(matrix);
        }

        else if (matrixSize >= 20)
        {
            Console.WriteLine("You've entered a number bigger/equal to 20 !");
        }
       
    }
 
    private static void Matrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0:00} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

