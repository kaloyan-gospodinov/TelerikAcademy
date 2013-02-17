using System;

class ExtractIntBit
{
    static void Main()
    {

        Console.Write("Enter integer:");
        int integer = int.Parse(Console.ReadLine());

        Console.Write("Enter position:");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int nAndMask = integer & mask;
        int bit = nAndMask >> position;
        Console.WriteLine("The bit value at position {0} in the integer {1} is: {2}", position, integer, bit);
        
    }
}

