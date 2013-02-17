using System;
using System.Collections.Generic;
using System.Linq;

class GetMax
{
    static int GetMaxNumber(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    static void Main()
    {
        Console.Write("Enter num1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter num2: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter num3: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest number is: {0}",GetMaxNumber(GetMaxNumber(num1, num2), num3));
    }
}

