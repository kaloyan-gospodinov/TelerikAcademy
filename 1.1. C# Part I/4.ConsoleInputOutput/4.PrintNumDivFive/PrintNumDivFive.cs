using System;


class PrintNumDivFive
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        uint first = uint.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        uint second = uint.Parse(Console.ReadLine());
        uint number = 0;

        while (first <= second)
        {
            first++;
            if (first % 5 == 0)
            {   
                number++;
            }
        }
        Console.WriteLine("{0} number/s is/are divisible by 5 in the range.", number);
    }
}

