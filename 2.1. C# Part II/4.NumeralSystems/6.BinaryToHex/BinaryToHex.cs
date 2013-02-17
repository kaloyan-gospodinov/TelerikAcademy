using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryToHex
{
    static void Main(string[] args)
    {
        Console.Write("Enter binary: ");
        string number = Console.ReadLine();
        string binHex = Hex(number);
        Console.WriteLine(binHex);
    }

    static string Hex(string num)
    {
        int strLength = num.Length;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < strLength; i = i + 4)
        {
            switch (num.Substring(i, 4))
            {
                case "1010": result.Append("A"); break;
                case "1011": result.Append("B"); break;
                case "1100": result.Append("C"); break;
                case "1101": result.Append("D"); break;
                case "1110": result.Append("E"); break;
                case "1111": result.Append("F"); break;
                case "0000": result.Append("0"); break;
                case "0001": result.Append("1"); break;
                case "0010": result.Append("2"); break;
                case "0011": result.Append("3"); break;
                case "0100": result.Append("4"); break;
                case "0101": result.Append("5"); break;
                case "0110": result.Append("6"); break;
                case "0111": result.Append("7"); break;
                case "1000": result.Append("8"); break;
                case "1001": result.Append("9"); break;
            }
        }
        return result.ToString();
    }
}

