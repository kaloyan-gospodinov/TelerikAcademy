using System;
using System.Collections.Generic;
using System.Linq;


class NumberAppearArray
{
    static int filler;
    static int number;

    static void Main()
    {
        Console.Write("Enter number to check: ");
        number = int.Parse(Console.ReadLine());

        Console.Write("Number of elements = ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        NumberAppear(array);

        Console.WriteLine("Number {0} appears {1} times in the defined array", number, filler);

    }

    static void NumberAppear(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                filler++;
            }
            
        }
    }

    
}

