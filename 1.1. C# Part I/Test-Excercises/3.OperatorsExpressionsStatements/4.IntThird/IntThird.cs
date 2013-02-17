using System;

class IntThird
{
    static void Main()
    {
        Console.Write("Enter int: ");
        long number = long.Parse(Console.ReadLine());
        bool exp;

        number = number / 100; 
        if (number % 10 == 7)
        {
            exp = true;
            Console.WriteLine("The third digit is seven: {0}", exp);
        }
        else
        {
            exp = false;
            Console.WriteLine("The third digit is not seven: {0}", exp);
        }
    }
}

