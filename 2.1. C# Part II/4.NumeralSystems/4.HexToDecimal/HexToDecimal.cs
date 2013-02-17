using System;
using System.Collections.Generic;
using System.Linq;

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal: ");
        string number = Console.ReadLine();

        Decimal(number);
    }

    private static void Decimal(string number)
    {
        int dec = Convert.ToInt32(number, 16);

        Console.WriteLine(dec);
    }
}

