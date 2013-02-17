using System;
using System.Text;

class IsoscelesCopyrightTriangle
{
    static void Main()
    {
        char code = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;

        double count = 1;
        double col = 7;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (j < (col / 2 - count / 2) || j > (col / 2 + count / 2 - 1))
                {
                    Console.Write(" ");
                }
                else
                    Console.Write(code);
            }
            count = count + 2;
            Console.WriteLine();
        }

    }
}

