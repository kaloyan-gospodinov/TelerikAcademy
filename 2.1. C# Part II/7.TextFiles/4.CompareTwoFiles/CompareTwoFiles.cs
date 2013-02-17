using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareTwoFiles
{
    static void Main()
    {
        try
        {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);


            using (StreamReader readerOne = new StreamReader("TextOne.txt", encoding),
                readerTwo = new StreamReader("TextTwo.txt", encoding))
            {

                string lineOne, lineTwo;
                int same = 0, different = 0;
                while ((lineOne = readerOne.ReadLine()) != null && 
                    (lineTwo = readerTwo.ReadLine()) != null)
                {
                    if (lineOne == lineTwo) same++;
                    else different++;
                }

                Console.WriteLine("There are {0} equal lines and {1} different!", same, different);
                
            }

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}

