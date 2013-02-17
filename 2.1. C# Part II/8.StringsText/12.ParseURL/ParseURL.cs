using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ParseURL
{
    static void Main(string[] args)
    {

        Console.Write("Enter URL: ");
        Uri uri = new Uri(Console.ReadLine());
        Console.WriteLine("[protocol] = {0}",uri.Scheme);
        Console.WriteLine("[server] = {0}", uri.Host);
        Console.WriteLine("[resource] = {0}", uri.AbsolutePath);
        

    }
}

