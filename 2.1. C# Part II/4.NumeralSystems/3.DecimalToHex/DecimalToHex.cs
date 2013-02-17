using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToHex
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Hex(number);

    }

    private static void Hex(int number)
    {
        string hexValue = number.ToString("X");
        char[] arr = hexValue.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(arr);
    }
}

