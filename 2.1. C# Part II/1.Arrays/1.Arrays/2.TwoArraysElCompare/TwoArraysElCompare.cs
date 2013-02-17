using System;

class TwoArraysElCompare
{
    static void Main()
    {
        Console.Write("Number of elements = ");
        int sizeOne = int.Parse(Console.ReadLine());

        int[] arrayOne = new int[sizeOne];

        for (int i = 0; i < sizeOne; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arrayOne[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Number of elements = ");
        int sizeTwo = int.Parse(Console.ReadLine());

        int[] arrayTwo = new int[sizeTwo];

        for (int i = 0; i < sizeTwo; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        


        bool isEqual = true;

        for (int i = 0; i < sizeOne; i++)
        {
            if (arrayOne [i] != arrayTwo[i])
            {
                isEqual = false;
                break;
            }
        }
        
        Console.WriteLine("Equal in values? --> {0}", isEqual);


    }
}

