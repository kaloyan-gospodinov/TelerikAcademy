using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class StringUnicode
{
    static void Main(string[] args)
    {
        Console.Write("Enter word: ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)(str[i]));
        }
        Console.WriteLine();
    }
        
}

