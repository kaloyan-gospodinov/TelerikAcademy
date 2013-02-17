using System;

class IntOddEven
{
    static void Main()
    {
        Console.Write("Enter int: ");
        int variable = int.Parse(Console.ReadLine());

        if (variable % 2 == 0)
        {
            Console.WriteLine("The integer is even");
        }
        else 
        {
            Console.WriteLine("The integer is odd");
        }
    }
}

