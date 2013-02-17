using System;

class BoolExprInt
{
    static void Main()
    {
        Console.WriteLine("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        int b = 7;
        int c = 5;
        bool exp;
        if (a%b == 0 && a%c ==0)
        {
            exp = true;
            Console.WriteLine("The integer can be divided by 7 and 5 in the same time: {0}", exp);
        }
        else
        {
            exp = false;
            Console.WriteLine("The integer can be divided by 7 and 5 in the same time: {0}",exp);
        }
    }
}
