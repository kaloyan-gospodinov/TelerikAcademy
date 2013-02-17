using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConcatTwoFiles
{
    static void Main(string[] args)
    {
        try
        {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);


            StreamReader readerOne = new StreamReader("TextOne.txt", encoding);
            StreamReader readerTwo = new StreamReader("TextTwo.txt", encoding);
            
            StreamWriter streamWriter = new StreamWriter("BothTexts.txt");

            using (readerOne)
            {
                using (streamWriter)
                {
                    string line;
                    while ((line = readerOne.ReadLine()) != null)
                    {
                        streamWriter.WriteLine((line));
                    }
                }
            }
            using (readerTwo)
            {
                using (streamWriter = File.AppendText("BothTexts.txt"))
                {
                    string line;
                    while ((line = readerTwo.ReadLine()) != null)
                    {
                        streamWriter.WriteLine((line));
                    }
                }
            }

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}

