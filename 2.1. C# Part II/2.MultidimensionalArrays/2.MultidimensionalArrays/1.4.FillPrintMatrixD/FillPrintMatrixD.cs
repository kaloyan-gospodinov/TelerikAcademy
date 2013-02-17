using System;
using System.Collections.Generic;
using System.Linq;

class FillPrintMatrixD
{
    static void Main()
    {
        Console.Write("Number of rows & columns= ");
        string stringNumber = Console.ReadLine();
        int matrixSize = int.Parse(stringNumber);
        int[,] matrix = new int[matrixSize, matrixSize];
        int num=0;

        
        for (int i = 0; i <= matrixSize/2; i++)
        {   
            
            for (int row = i; row < matrixSize - i; row++)
            {
                matrix[row, i] = num++;
            }

            for (int col = i; col < matrixSize -i; col++)
            {
                matrix[matrixSize - i, col] = num++;  
            }

            for (int row = matrixSize - i; row > i; row--)
            {
                matrix[row, matrixSize - i] = num++;
            }

            for (int col = matrixSize - i; col > i; col--)
            {
                matrix[i, col] = num++;
            }

        }


        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }           
        
    }
 
   
    
}

