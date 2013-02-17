using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


class AllPrimeNum
{
    static void Main()
    {
        bool[] numbers = new bool[10000000];
        int length = numbers.Length;


        for (int i = 2; i < Math.Sqrt(length); i++)
        {
            if (!numbers[i])
            {
                for (int j = (i*i); j < length; j+=i)
                {
                    numbers[j] = true;
                }
               
            }
        }

        for (int i = 2; i < length; i++)
        {
            if (!numbers[i])
            {
                Console.Write("{0} ",i);
            }
        }

    }
}

