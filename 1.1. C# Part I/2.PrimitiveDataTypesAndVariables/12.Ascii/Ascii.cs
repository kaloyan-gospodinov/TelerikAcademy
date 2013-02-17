using System;
using System.Collections.Generic;
using System.Text;

class Ascii
{
    static void Main()
    {
        Console.WriteLine("\nASCII Table:");
        for (byte codeSymbol = 0; codeSymbol < 128; codeSymbol++)
        {
            Console.Write("{0} - {1}\t", codeSymbol, (char)codeSymbol);
        }
        Console.WriteLine();

        Console.WriteLine("\nExtended ASCII Codes:");
        for (short extendedCodes = 128; extendedCodes <= 255; extendedCodes++)
        {
            Console.Write("{0} - {1}\t", extendedCodes, (char)extendedCodes);
        }
        Console.WriteLine("\n");
    }
}

