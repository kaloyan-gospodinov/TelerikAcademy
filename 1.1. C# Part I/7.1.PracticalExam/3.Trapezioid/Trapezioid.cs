using System;

class Trapezioid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        
       
        for (int i = 1; i <= n; i++)
        {
            Console.Write('.');
        }
        for (int i = 1; i <= n; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
 
        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j <= n - i + 1; j++)
            {
                Console.Write('.');
            }
            Console.Write('*');
            for (int j = 1; j <= i + n - 3; j++)
            {
                Console.Write('.');
            }
            Console.Write('*');
            Console.WriteLine();
        }

        for (int i = 1; i <= 2 * n; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();

    }
}

