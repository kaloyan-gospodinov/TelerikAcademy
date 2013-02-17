using System;
using System.Collections.Generic;
using System.Linq;


class ArrayOfStrings
{
    
    static void Main()
    {
        string[] array = { "zebra", "elephant", "donkey", "cat", "mice", "quake", "alphabet" };

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));

        foreach (string element in array)

        {
            Console.WriteLine(element);
        }

    }
    
}
