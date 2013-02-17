using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DeleteSameWords
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader("Text.txt");
            StreamWriter writer = new StreamWriter("TextOne.txt");

            string regex = @"\b(" + String.Join("|", File.ReadAllLines("words.txt")) + @")\b";

            using (reader)
            {
                string line;

                using (writer)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(Regex.Replace(line, regex, String.Empty));
                    }
                }
                

            }

        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
        catch (System.Security.SecurityException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
        catch (UnauthorizedAccessException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
        catch (OutOfMemoryException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
        catch (Exception exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}

