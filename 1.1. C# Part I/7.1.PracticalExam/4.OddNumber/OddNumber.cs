using System;


class OddNumber
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        long output = 0;

        for (int i = 1; i <= n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            output ^= number;
        }
        Console.WriteLine(output);
    }
}

