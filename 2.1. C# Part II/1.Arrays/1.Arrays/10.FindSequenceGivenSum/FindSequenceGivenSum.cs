using System;
using System.Collections.Generic;
using System.Linq;

class FindSequenceGivenSum
{
    static void Main()
    {
        Console.Write("Number of elements = ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter sum = ");
        int s = int.Parse(Console.ReadLine());
        

        for (int i = 0; i < size; i++)
        {
            for (int j = i, sum = 0; j < size; j++)
            {
                sum += array[j];

                if (sum == s)
                {
                    int length = j - i + 1;

                    for (int k = 0; k < length; k++)
                    {
                        Console.WriteLine(array[i + k]);
                    }
                }
            }
        }
    }
}

