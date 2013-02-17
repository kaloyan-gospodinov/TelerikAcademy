using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReplaceStartToFinish
{
    static void Main(string[] args)
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
                    writer.WriteLine(line.Replace("start", "finish"));
                }

            }

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}

