using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplaceHTMLTags
{
    static void Main(string[] args)
    {
        StringBuilder text = new StringBuilder("<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>");

        string[] forbidden = { "<a href=\"","\">" ,"</a>" };
        string[] allowed = {"[URL=", "]","[/URL]"};

        for (int i = 0; i < forbidden.Length; i++)
        {
            text = text.Replace(forbidden[i], allowed[i]);
        }
        Console.WriteLine(text);
    }
}

