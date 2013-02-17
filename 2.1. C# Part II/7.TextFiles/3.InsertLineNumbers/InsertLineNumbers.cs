using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InsertLineNumbers
{
    static void Main(string[] args)
    {
        try
        {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

            StreamReader reader = new StreamReader("Text.txt", encoding);
            StreamWriter streamWriter = new StreamWriter("TextLines.txt");

            using (reader)
            {
                string s = "";
                int counter = 1;
                StringBuilder sb = new StringBuilder();

                while ((s = reader.ReadLine()) != null)
                {
                    var lineOutput = (counter++) + (" ") + (s);
                    sb.Append(lineOutput);
                    streamWriter.WriteLine(lineOutput);
                }
            }

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}

