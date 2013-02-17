using System;
using System.Collections.Generic;
using System.Linq;


class BinRepresent
{
    static void Main(string[] args)
    {
        Console.Write("Enter number in short: ");
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine(ToBin(number));
        
    }

    static string ToBin(short number)
    {
        string value = " ";

        for (int i = 0; i < 16; i++)
        {
            value = (number >> i & 1) + value;
        }

        return value;
    }
}

