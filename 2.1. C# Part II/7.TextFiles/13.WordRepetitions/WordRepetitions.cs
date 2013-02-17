using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



class WordRepetitions
{
    static void Main(string[] args)
    {
        try
        {
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            StreamReader reader = new StreamReader("text.txt", win1251);
            StreamWriter result = new StreamWriter("result.txt");
            string[] words = File.ReadAllLines("words.txt");
            int[] repetitions = new int[words.Length];

            using (reader)
            {
                using (result)
                {
                    for (string line; (line = reader.ReadLine()) != null; )
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            repetitions[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }
                    }

                    Array.Sort(repetitions, words);

                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        result.WriteLine("{0}: {1}",words[i],repetitions[i]);
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

