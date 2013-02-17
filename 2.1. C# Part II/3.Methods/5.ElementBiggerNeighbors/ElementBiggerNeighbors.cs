using System;
using System.Collections.Generic;
using System.Linq;

public class ElementBiggerNeighbors
{
    static int number;

    static void Main()
    {
        Console.Write("Enter index position: ");
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


    }

    public static void NumberAppear(int[] array)
    {
        if (number == 0)
        {
            if (array[number] > array[number + 1])
            {
                Console.WriteLine("{0} at position {1} is bigger than {2} at position {3}", array[number], number, array[number + 1], number + 1);
            }
            else if (array[number] < array[number + 1])
            {
                Console.WriteLine("{0} at position {1} is smaller than {2} at position {3}", array[number], number, array[number + 1], number + 1);
            }

            else if (array[number] == array[number + 1])
            {
                Console.WriteLine("{0} at position {1} is equal to {2} at position {3}", array[number], number, array[number + 1], number + 1);
            }
        }

        if (number> 0 && number <array.Length -1 )
        {
            if (array[number] > array[number + 1])
            {
                Console.WriteLine("{0} at position {1} is bigger than {2} at position {3}",array[number],number,array[number+1],number+1);
            }
            else if (array[number] < array[number + 1])
            {

                Console.WriteLine("{0} at position {1} is smaller than {2} at position {3}", array[number], number, array[number + 1], number + 1);
            }

            else if (array[number] == array[number + 1])
            {
                Console.WriteLine("{0} at position {1} is equal to {2} at position {3}", array[number], number, array[number + 1], number + 1);
            }

            if (array[number] > array[number - 1])
            {
                Console.WriteLine("{0} at position {1} is bigger than {2} at position {3}", array[number], number, array[number - 1], number - 1);
            }

            else if (array[number] < array[number - 1])
            {
                Console.WriteLine("{0} at position {1} is smaller than {2} at position {3}", array[number], number, array[number - 1], number - 1);
            }

            else if (array[number] == array[number - 1])
            {
                Console.WriteLine("{0} at position {1} is equal to {2} at position {3}", array[number], number, array[number - 1], number - 1);
            }
        }

        if (number == (array.Length-1))
        {
            if (array[number] > array[number - 1])
            {
                Console.WriteLine("{0} at position {1} is bigger than {2} at position {3}", array[number], number, array[number - 1], number - 1);
            }

            else if (array[number] < array[number - 1])
            {
                Console.WriteLine("{0} at position {1} is smaller than {2} at position {3}", array[number], number, array[number - 1], number - 1);
            }

            else if (array[number] == array[number - 1])
            {
                Console.WriteLine("{0} at position {1} is equal to {2} at position {3}", array[number], number, array[number - 1], number - 1);
            }
        }
        
    }
}

