using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractDates
{
    static void Main()
    {
        //string str = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        //string characters = @"DD.MM.YYYY";

        //foreach (var item in Regex.Matches(str, characters))
        //{
        //    Console.WriteLine(item);
        //}

        string str = "\tid 01CA4692.A44F1F3E@blah.blah.co.uk; Tue, 6 Oct 2009 15:38:16 +0100";
        var trimmed = str.Split(';')[1].Trim();
        var x = DateTime.Parse(trimmed);

        Console.WriteLine(x);
    }
}

