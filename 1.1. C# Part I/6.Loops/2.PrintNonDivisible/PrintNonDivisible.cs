using System;


class PrintNonDivisible
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInput = Console.ReadLine();
        int n = int.Parse(consoleInput);
        int number = 0;

        while (number < n )
        {
            number++;
            if (number % 3 != 0 && number % 7 != 0)
            {
                Console.Write("{0}, ", number);
            }
        }
        
    }
}

