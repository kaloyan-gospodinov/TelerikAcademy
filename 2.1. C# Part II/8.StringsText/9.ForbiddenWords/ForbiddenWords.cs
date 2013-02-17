using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ForbiddenWords
{
    static void Main(string[] args)
    {
        StringBuilder text = new StringBuilder ("Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.");

        string[] forbidden = {"PHP", "CLR", "Microsoft" };
        

        for (int i = 0; i < forbidden.Length; i++)
        {
            text = text.Replace(forbidden[i], new string('*', forbidden[i].Length));
        }
        Console.WriteLine(text);
    }
}


