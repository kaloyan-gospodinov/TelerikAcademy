using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class UpcaseWords
{
    static void Main(string[] args)
    {
        string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        text = Regex.Replace(text, "<upcase>(.*?)</upcase>", m =>  m.Groups[1].Value.ToUpper());

        //while (text.IndexOf(keyword) != -1)
        //{
        //    int indexStart = text.IndexOf(keyword);
        //    int indexEnd = text.IndexOf(closing);
        //    string temp = text.Substring(indexStart + keyword.Length, indexEnd - indexStart - keyword.Length);
        //    text = text.Replace(keyword + temp + closing, temp.ToUpper());
        //}
        
        Console.WriteLine(text);
        
    }
}

