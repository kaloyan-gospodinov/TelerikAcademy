using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

    
class PrintOddLines
{
    static void Main()
    {
        Encoding win1251 = Encoding.GetEncoding("Windows-1251");
        StreamReader reader = new StreamReader("Sample.txt",win1251);

        using (reader)
        {
            int lineNumber = -1;

            // Read first line from the text file
            string line = reader.ReadLine();

            // Read the other lines from the text file
            while (line != null)
            {
                lineNumber = lineNumber + 2;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }
        }
    }
}

