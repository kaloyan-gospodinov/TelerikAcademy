using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SumMatrix
{
    class SumMatrix
    {
        static void Main(string[] args)
        {
            try
            {
                Encoding win1251 = Encoding.GetEncoding("Windows-1251");
                StreamReader reader = new StreamReader("Sample.txt", win1251);
                StreamWriter result = new StreamWriter("Result.txt");


                int matrixSize = int.Parse(reader.ReadLine());
                int[,] iMap = new int[matrixSize, matrixSize];
                using (reader)
                {
                    for (int i = 0; i < matrixSize; i++)
                    {
                        string[] line = reader.ReadLine().Split(' ');
                        for (int j = 0; j < matrixSize; j++)
                        {
                            iMap[i, j] = int.Parse(line[j]);
                        }
                    }
                }
                int maxSum = int.MinValue;



                for (int i = 0; i < iMap.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < iMap.GetLength(1) - 1; j++)
                    {
                        int sum = iMap[i, j] + iMap[i + 1, j] + iMap[i, j + 1] + iMap[i + 1, j + 1];
                        maxSum = Math.Max(maxSum, sum);
                    }
                }

                using (result)
                {
                    result.WriteLine(maxSum);
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error: {0}.", exc.Message);
            }
        }
    }
}
