using System;
using System.Linq;

class SequenceMaxSum
{
    static void Main()
    {
        Console.Write("Number Number N = ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }


        int start = 0;
        int end = 0;
        int sum = 0;
        int bestSum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i+j <n)
                {
                    sum = sum + array[i + j];
                }
            
                if (sum > bestSum)
                {
                    bestSum = sum;
                    start = i;      
                    end = i + j;
                }
            }

            sum = 0;
            
        }

        Console.Write("The elements with the max sum: ");
        for (int i = start; i < end+1; i++)
        {
            Console.Write("{0}; ", array[i]);
        }
        Console.WriteLine("\nThe sum is: {0}", bestSum);
       

    }
}

