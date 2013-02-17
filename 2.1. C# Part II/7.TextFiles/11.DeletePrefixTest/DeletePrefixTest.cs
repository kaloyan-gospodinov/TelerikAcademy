using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class DeletePrefixTest
{
    static void Main()
    {
        try
        {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);
            StreamReader reader = new StreamReader("Text.txt", encoding);
            StreamWriter writer = new StreamWriter("TextOne.txt");

            using (reader)
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"(\b)test(\d|\w|_)*(\b)", " "));
                }
            }

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}

