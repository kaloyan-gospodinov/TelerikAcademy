using System;
using System.Collections.Generic;
using System.Linq;



class ArrayBinSearch
{
    static void Main()
    {
        //Console.Write("Number of elements = ");
        //int n = int.Parse(Console.ReadLine());

        //int[] array = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("arr[{0}] = ", i);
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //int k = int.Parse(Console.ReadLine());
        
        //int index = Array.BinarySearch(array, k);
        
        //Console.WriteLine(index);

        // Create an unsorted array of string elements
        
        int[] array = {9, 0, 3, 1, 3, 6, 7, 7 };
        int K = 4;

        Array.Sort(array);
        //Array.Sort(array, (x, y) => (x).CompareTo(y));

        int searchedNumber = Array.BinarySearch(array, K);
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        if (searchedNumber < -1)
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[~searchedNumber - 1]);
        }
        else if (~searchedNumber == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[searchedNumber]);
        }
    
       
    }
}

