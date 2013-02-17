using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReverseWords
{
    static void Main(string[] args)
    {

        string sentence = "C# is not C++, not PHP and not Delphi!";
        char[] separate = { ' ', '!', ',', '.', '?' };
        string[] parts = sentence.Split(separate, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(parts);

        string[] arr = Regex.Split(sentence, "[A-Za-z0-9#+]");
        List<string> characters = new List<string>();
        StringBuilder reversed = new StringBuilder();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != String.Empty)
            {
                characters.Add(arr[i]);
            }
        }


        for (int i = 0; i < characters.Count; i++)
        {
            if (i < parts.Length)
            {
                reversed.Append(parts[i]);
            }

            reversed.Append(characters[i]);
        }
        Console.WriteLine(reversed.ToString());
    }
}

