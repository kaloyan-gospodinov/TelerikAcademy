using System;
using System.Linq;

class BiggerIndexThanNeighbors
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

        
        int index = NumberAppear(array);
        if (index == -1)
        {
            Console.WriteLine("There is no biggest element!");
        }
        else
        {
            Console.WriteLine("The index of the biggest element is/((-1) if none): {0} with a value of {1} ", NumberAppear(array), array[NumberAppear(array)]);
        }
    }

    static int NumberAppear(int[] array)
    {

        for (int i = 1; i < array.Length - 1; i++)
        {
            if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
            {
                return i;
            }
        }
        return -1;
        
    }
}

