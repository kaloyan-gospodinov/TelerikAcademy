using System;
using System.Numerics;

class TwoIntSum
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInputOne = Console.ReadLine();
        int n = Convert.ToInt32(consoleInputOne);

        Console.Write("x = ");
        string consoleInputTwo = Console.ReadLine();
        int x = Convert.ToInt32(consoleInputTwo);

        if ((n < 0) || (x <= 0))
        {
            Console.WriteLine("Enter new int numbers for n & x");
            return;
        }

        decimal factorial = 1;
        decimal power = 1;
        decimal sum = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum += (factorial / power);

        }
        Console.WriteLine("Sum of (n!)/(x^n) = {0}", 1 + sum);
    }
}

