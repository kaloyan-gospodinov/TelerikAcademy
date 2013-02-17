using System;
using System.Threading;
using System.Globalization;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string nString = Console.ReadLine();
        decimal N = decimal.Parse(nString);

        string mString = Console.ReadLine();
        decimal M = decimal.Parse(mString);

        string pString = Console.ReadLine();
        decimal P = decimal.Parse(pString);

        decimal result = ((N * N) + (1 / (M * P)) + 1337) / (N - (128.523123123M * P)) + (decimal)Math.Sin((int)M % 180);
        Console.WriteLine("{0:0.000000}", result);
    }
}

