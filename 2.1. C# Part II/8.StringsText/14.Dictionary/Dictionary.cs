using System;
using System.Collections.Generic;
using System.Linq;


class Dictionary
{
    static void Main(string[] args)
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

       
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add(".NET", "platform for applications from Microsoft");
        dict.Add("CLR", "managed execution environment for .NET");
        dict.Add("namespace", "hierarchical organization of classes");
        
        
        foreach (var entry in dict)
        {
            if (entry.Key.ToLowerInvariant() == word.ToLowerInvariant())
            {
                Console.WriteLine("{0} - {1}",word,entry.Value);
            }
        }
    }
}

