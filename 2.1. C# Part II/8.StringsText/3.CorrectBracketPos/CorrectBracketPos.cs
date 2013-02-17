using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CorrectBracketPos
{
    public static void Main()
    {
        Console.Write("Enter expression: ");
        string text = Console.ReadLine();
        bool truth = CorrectBrakets(text);
        Console.WriteLine(truth);

    }

    public static bool CorrectBrakets(string text)
    {

        int count  = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '(')
            {
                count ++;
            }
            else if (text[i] == ')')
            {
                count--;
            }
            else if (count < 0)
            {
                return false;
            }

        }
        if (count == 0)
        {
            return true;
        }
       
        return false;
        

    }
}

