using System;
using System.Linq;

class AlphabetWordSearch
{
    static void Main()
    {
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        Console.Write("Enter word: ");
        string str = (Console.ReadLine().ToLower());
        char[] chararray = str.ToCharArray();

        for (int i = 0; i < chararray.Length; i++)
        {
            Console.WriteLine("{0} [{1}]", chararray[i], chararray[i] - 'a');
            
        }

    }
}

