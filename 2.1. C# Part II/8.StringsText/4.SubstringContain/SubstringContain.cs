using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubstringContain
{
    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string lower = text.ToLower();
        string keyword = "in";


        int index = lower.IndexOf(keyword);
        int counter = 0;
        while (index != -1)
        {
            index = lower.IndexOf(keyword, index + 1);
            counter++;
        }
        Console.WriteLine("There are {0} times the word \"{1}\" in the given text! ", counter,keyword);
    }
}

