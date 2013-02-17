using System;
using System.Linq;

class ExtractSentences
{
    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] keyword = {"in"};

        string[] sentences= text.Split('.');

        var sentenceQuery = from sentence in sentences
                            let w = sentence.Split(new char[] {'?', '!', ' '})
                            where w.Distinct().Intersect(keyword).Count() == keyword.Count()
                            select sentence;

        foreach (string str in sentenceQuery)
        {
            Console.WriteLine((str + ".").Trim());
        }

    }

 
}

