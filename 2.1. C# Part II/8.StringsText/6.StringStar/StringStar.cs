using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringStar
{
    static void Main()
    {
        Console.Write("Enter string <= 20 chars: ");
        string text = Console.ReadLine();

        if (text.Length==20)
        {
            Console.WriteLine(text);
        }
        else if (text.Length > 20)
        {
            Console.WriteLine("You've endtered more than 20 characters");
        }
        else if (text.Length < 20)
        {
            int counter = 20-text.Length;
            StringBuilder stars= new StringBuilder();
            string star = "*";

            for (int i = 0; i < counter; i++)
            {
                stars.Append(star);
            }
            Console.WriteLine(text +stars);
        }

        //abcdefghijklmnopqrst
    }
}

