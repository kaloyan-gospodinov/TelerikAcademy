using System;
using System.Collections.Generic;
using System.Linq;


class CalculateIntNum
{
    static void Main(string[] args)
    {
        int[] array = EnterValues();

        PrintResults(array);
    }

    private static void PrintResults(int[] array)
    {
        Console.WriteLine("The minimal element in the array is: {0}", MinInt(array));
        Console.WriteLine("The maximal element in the array is: {0}", MaxInt(array));
        Console.WriteLine("The average is: {0}", Average(array));
        Console.WriteLine("The sum is: {0}", Sum(array));
        Console.WriteLine("The product is: {0}", Product(array));
    }

    private static int[] EnterValues()
    {
        Console.Write("Number of integers = ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];


        for (int i = 0; i < size; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    private static int MinInt(int[] array)
    {
        return array.Min();
    }

    private static int MaxInt(int[] array)
    {
        return array.Max();
    }

    static double Average(int[] array)
    {

        double average = array.Average();

        return average;
    }

    private static int Sum(int[] array)
    {
        return array.Sum();
    }

    private static int Product(int[] array)
    {   
        int prod = 1;
        foreach (int value in array) 
        {
                prod *= value;
        }

        return prod;
    }
}



