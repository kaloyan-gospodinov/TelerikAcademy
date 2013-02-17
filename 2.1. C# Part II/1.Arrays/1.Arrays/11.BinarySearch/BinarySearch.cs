using System;
using System.Linq;


class BinarySearch
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

        Console.Write("Enter element = ");
        int element = int.Parse(Console.ReadLine());

        int index = Array.BinarySearch(array, element);
       
        Console.WriteLine(index);
    }
}

