using System;
using System.Collections.Generic;
using System.Linq;

class ConvertSToD
{
    static void Main()
    {
        Console.WriteLine("Numeric systems between 2 and 16!");
        Console.Write("Enter numeric system to start from: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Enter numeric system to be converted to: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter value: ");
        string number = Console.ReadLine();


        FromDecimal(ToDecimal(number, s), d);
        

    }

    static int ToDecimal(string number, int numSysOne)
    {
        int dec = 0;

        for (int i = 0; i < number.Length; i++)
        {
            dec = dec << 1;
            if (number[i] == '1')
            {
                dec = dec ^ 1;
            }
        }

        return dec;
    }

    static void FromDecimal(int numSysTwo, int dec)
    {
        List<int> binary = new List<int>();
        while (dec > 0)
        {
            binary.Add(dec % numSysTwo);
            dec = dec / numSysTwo;
        }
        binary.Reverse();
        for (int i = 0; i < binary.Count; i++)
        {
            Console.Write("{0} ", binary[i]);
        }
        
    }
}

