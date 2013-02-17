using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class BasicLanguage
{
    static void Main(string[] args)
    {
        StringBuilder source = new StringBuilder();
        string input;
        

        do
        {
            input = (Console.ReadLine());
            source.Append(input);
            
        } while (input != "EXIT;");

        string[] forbidden = { "<a href=\"", "\">", "</a>" };
        

        for (int i = 0; i < forbidden.Length; i++)
        {
            source = source.Remove(forbidden[i]);
        }
        Console.WriteLine(source);
    }
    
}

