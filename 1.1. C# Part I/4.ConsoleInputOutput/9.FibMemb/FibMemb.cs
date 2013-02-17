using System;


class FibMemb
{
    static void Main()
    {
        decimal first = 0;
        Console.WriteLine(first);

        decimal second = 1;
        Console.WriteLine(second);

        decimal sum = 0;

        for (int i = 1; i < 100; i++)
        {
            sum = first + second;
            first = second;
            second = sum;
            Console.WriteLine(sum);
        }
        
    }
}

