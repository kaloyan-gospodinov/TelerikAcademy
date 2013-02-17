using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.Write("Number Array Size = ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int iMin;
        int temp;
        

        for (int i = 0; i < n - 1; i++)
        {
            iMin = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[iMin])
                {
                    iMin = j;
                }
            }

            temp = array[iMin];
            array[iMin] = array[i];
            array[i] = temp;
        }

        Console.WriteLine("The array after Selection Sort is: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("array["+ i +"] = {0}", array[i]);
        }

        
        
    }
}

