using System;

class TwoCharCompare
{
    static void Main()
    {
        Console.Write("Number of elements = ");
        int sizeOne = int.Parse(Console.ReadLine());
        char[] arrayOne = new char[sizeOne];
        for (int i = 0; i < sizeOne; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arrayOne[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Number of elements = ");
        int sizeTwo = int.Parse(Console.ReadLine());
        char[] arrayTwo = new char[sizeTwo];
        for (int i = 0; i < sizeTwo; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arrayTwo[i] = char.Parse(Console.ReadLine());
        }

        bool equalSize = true;
        bool isEqual = true;

        for (int i = 0; i < sizeOne; i++)
        {
            if (arrayOne[i] != arrayTwo[i])
            {
                isEqual = false;
                break;
            }
        }
        if (sizeOne != sizeTwo)
        {
            equalSize = false;
        }
        Console.WriteLine("Equal in size? --> {0}", equalSize);
        Console.WriteLine("Equal in values? --> {0}", isEqual);
    }
}

