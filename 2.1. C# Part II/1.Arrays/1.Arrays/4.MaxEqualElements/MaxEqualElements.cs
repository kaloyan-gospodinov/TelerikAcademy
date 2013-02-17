using System;

class MaxEqualElements
{
    static void Main()
    {
        Console.Write("Number of elements = ");
        int size = int.Parse(Console.ReadLine());

        int[] array =  new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
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
        

        for (int i = (bestEnd-bestLen+1); i< bestEnd+1; i++)
        {
            Console.Write("{0}, ",array[i+1]);
        }
    }
}

