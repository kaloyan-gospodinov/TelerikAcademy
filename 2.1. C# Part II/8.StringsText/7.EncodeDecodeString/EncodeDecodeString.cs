using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EncodeDecodeString
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string text = Console.ReadLine();
        
        string cipher = "abcdefghijklmn";

        StringBuilder sb = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i++)
        {
            sb.Append((char)(text[i] ^ cipher[i % cipher.Length]));
        }

        string encrypt = sb.ToString();

        
        StringBuilder sbTwo = new StringBuilder(text.Length);
        for (int i = 0; i < encrypt.Length; i++)
        {
            sbTwo.Append((char)(encrypt[i] ^ cipher[i % cipher.Length]));
        }
        string decrypt = sbTwo.ToString();


        Console.WriteLine( encrypt);
        Console.WriteLine(decrypt);
    }




    
}
