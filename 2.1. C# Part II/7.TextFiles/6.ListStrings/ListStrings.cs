using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class ListStrings
{
    static void Main(string[] args)
    {
        try
        {
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            StreamReader reader = new StreamReader("Sample.txt", win1251);
            StreamWriter result = new StreamWriter("Result.txt");
            List<string> lines = new List<string>();

            using (reader)
            {
                using (result)
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);

                    }
                    lines.Sort();

                    for (int i = 0; i < lines.Count; i++)
                    {
                        result.WriteLine(lines[i]);
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

