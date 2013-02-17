using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Binary(number);
        
    }

    private static void Binary(int number)
    {
        string binary = Convert.ToString(number, 2);
        char[] arr = binary.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(arr);
    }
}
