using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class PHPVariables
{
    static void Main()
    {       StringBuilder source = new StringBuilder();
            string input = "";
            string[] pattern = {
                                   @"#.*", //remove # comments
                                   @"//.*", //remove // comments
                                   @""".*(/\*).*(\*/).*""", // ignore /* */ comments in quotes
                                   @"(\\){2}", //remove the double backslash to differ from \\$var - not escaped var
                                   @"\\\$" //remove it because it is escaped var
                               };
            while (input != "?>")
            {
                input = (Console.ReadLine());
                foreach (string patternString in pattern)
                {
                    foreach (Match match in Regex.Matches(input, patternString))
                    {
                        input = input.Replace(match.ToString(), " ");
                    }
                }
                source.Append(input);
            } 

            string text = source.ToString();
            string patternMultiLineComment = @"/\*.*?\*/"; //remove all multiline comments
            foreach (Match match in Regex.Matches(text, patternMultiLineComment))
            {
                text = text.Replace(match.Value, "");
            }

            Dictionary<string, int> variables = new Dictionary<string, int>();

            string patternVars = @"\$(\w{1,})"; //get var names with 1 or more symbols (a-Z0-9_)
            foreach (Match match in Regex.Matches(text, patternVars))
            {
                string phpVar = match.Groups[1].Value;
                if (!variables.ContainsKey(phpVar))
                {
                    variables.Add(phpVar, 1);
                    
                }
            }
            List<string> list = variables.Keys.ToList();
            list.Sort(StringComparer.Ordinal);
            Console.WriteLine(list.Count);
            source.Clear();
            foreach (string item in list)
            {
                source.Append(item);
                source.Append("\n");
            }
            Console.WriteLine(source);
    }
    
   
}

