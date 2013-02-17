using System;

class IntThird
{
    static void Main()
    {

        Console.Write("Enter number:");
        long number = long.Parse(Console.ReadLine());
        bool exp;
        if ((number / 100) % 10 == 7)
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
