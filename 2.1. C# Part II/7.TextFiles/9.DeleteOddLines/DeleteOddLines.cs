using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class DeleteOddLines
{
    static void Main()
    {
        try
        {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);
            string source = "Text.txt";
            
            List<string> lines = new List<string>();
            int lineNumber = 1;

            lineNumber = ReadLines(encoding, source, lines, lineNumber);

            WriteLines(source, lines);

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }

    private static void WriteLines(string source, List<string> lines)
    {
        using (StreamWriter writer = new StreamWriter(source))
        {
            for (int i = 0; i < lines.Count; i++)
            {
                writer.WriteLine(lines[i]);
            }
        }
    }

    private static int ReadLines(System.Text.Encoding encoding, string source, List<string> lines, int lineNumber)
    {
        using (StreamReader reader = new StreamReader(source, encoding))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 0)
                {
                    lines.Add(line);
                }
                line = reader.ReadLine();
                lineNumber++;
            }
        }
        return lineNumber;
    }
}

