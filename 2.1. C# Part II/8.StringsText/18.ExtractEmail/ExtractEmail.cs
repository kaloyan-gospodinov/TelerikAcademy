using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractEmail
{
    static void Main()
    {
        string str = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string characters = @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6} ";

        foreach (var item in Regex.Matches(str, characters))
        {
            Console.WriteLine(item);
        }
    }

}

