using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
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

        //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //int size = array.Length;

        int iMin;
        int temp;


        for (int i = 0; i < size - 1; i++)
        {
            iMin = i;

            for (int j = i + 1; j < size; j++)
            {
                if (array[j] < array[iMin])
                {
                    iMin = j;
                }
            }

            temp = array[iMin];
            array[iMin] = array[i];
            array[i] = temp;
        }

        int end = 0;
        int len = 1;
        int bestEnd = 0;
        int bestLen = 1;

        for (int i = 0; i < size - 1; i++)
        {

            if ((array[i] != array[i + 1]))
            {
                len = 1;
            }

            else if ((array[i] == array[i + 1]))
            {
                end = i;
                len++;

                if (bestLen < len)
                {
                    bestLen = len;
                    bestEnd = end;
                }

            }

            if (len > bestLen)
            {
                bestLen = len;
                bestEnd = array[array.Length - 1];
            }
        }

        Console.Write("The most frequent number in the array is: ");

        for (int i = (bestEnd ); i < bestEnd + 1; i++)
        {
            Console.Write("{0} ", array[i + 1]);
        }


        Console.WriteLine("-> {0} times",bestLen);

    }
}

