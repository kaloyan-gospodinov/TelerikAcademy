using System;
using System.Collections.Generic;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        Decimal(number);
    }

    private static void Decimal(string number)
    {
        long dec = Convert.ToInt64(number, 2);

        Console.WriteLine(dec);
    }
}

