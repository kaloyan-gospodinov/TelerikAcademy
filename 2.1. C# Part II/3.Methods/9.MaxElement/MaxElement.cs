using System;
using System.Collections.Generic;
using System.Linq;


public static class MaxElement
{
    public static T[] SubArray<T>(this T[] data, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(data, index, result, 0, length);
        return result;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number to check: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Number of elements = ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        Array.Sort(array);
        PrintArray(array);

        Console.Write("Enter start index to check: ");
        int startIndex = int.Parse(Console.ReadLine());

        int[] sub = array.SubArray(startIndex, (array.Length - startIndex));

        PrintArray(sub);
        Console.WriteLine("The maximal element in the array is: {0}",MaxInt(sub));
    }

    private static int MaxInt(int[] sub)
    {
        return sub.Max();
    }

    private static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}

