using System;
using System.Linq;

class MaxIncreaseArray
{
    static void Main()
    {
        Console.Write("Number of elements = ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }


        int end = 0;
        int len = 1;
        int bestEnd = 0;
        int bestLen = 1;

        for (int i = 0; i < length - 1; i++)
        {

            if ((array[i] < array[i + 1]))
            {
                end = i;
                len++;

                if (bestLen < len)
                {
                    bestLen = len;
                    bestEnd = end;
                }

            }
            
            else 
            {
                len = 1;
            }

            if (len > bestLen)
            {
                bestLen = len;
                bestEnd = array[array.Length - 1];
            }
        }

        Console.WriteLine(bestLen);
        Console.WriteLine(bestEnd);

        for (int i = (bestEnd - bestLen + 1); i < bestEnd + 1; i++)
        {
            Console.Write("{0}, ", array[i + 1]);
        }
    }
}

