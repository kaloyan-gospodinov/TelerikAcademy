using System;
using System.Text;



class IsoscelesCopyrightTriangle
{

    static void Main()
    {
        char symbol = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("   {0}\n  {0}{0}{0}\n {0}{0}{0}{0}{0}", symbol);
    }
}





