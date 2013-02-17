using System;

class NCatalanNum
{
    static decimal Factorial(decimal number)
    {
        decimal sum = 1;
        for (int i = 1; i <= number; i++)
        {
            sum = sum * i;
        }
        return sum;
    }
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal CatalanSum = 0;
        CatalanSum = (Factorial(2 * n)) / ((Factorial(n + 1) * Factorial(n)));
        Console.WriteLine("The {0}th Catalan number is: {1}", n, CatalanSum);
    }
}

