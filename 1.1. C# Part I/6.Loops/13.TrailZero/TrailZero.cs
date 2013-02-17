using System;
using System.Numerics;

class TrailZero
{
    static void Main()
    {
        Console.Write("Write n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger trailing = 0;
        for (int i = 5; i <= n; i*=5)
        {
            trailing = trailing + (n / i);
        }

        BigInteger factorial = 1;

        for (int j = 1; j <= n; j++)
        {
            factorial *= j;
        }

        Console.WriteLine("N! = {0}", factorial);
        Console.WriteLine("The trailing zeroes of {0}! are {1}.", n, trailing);
    }
}

