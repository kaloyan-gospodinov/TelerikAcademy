using System;


class PrintNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInput = Console.ReadLine();
        int n = int.Parse(consoleInput);
        int number = 0;
       
        while (number < n)
        {
            number++;
            Console.Write("{0}, ", number);
        }
    }
}

