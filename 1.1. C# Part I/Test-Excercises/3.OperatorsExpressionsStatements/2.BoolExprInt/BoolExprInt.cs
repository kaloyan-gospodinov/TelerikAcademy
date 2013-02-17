using System;

class BoolExprInt
{
    static void Main()
    {
        Console.Write("Enter int: ");
        int variable = int.Parse(Console.ReadLine());
        bool exp;

        if (variable % 7 == 0 && variable % 5 == 0)
        {
            exp = true;
            Console.WriteLine("The integer is divisable by both 5 and 7");
        }
        else
        {
            exp = false;
            Console.WriteLine("The integer is not divisable by both 5 and 7");
        }
    }
}

