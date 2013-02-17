using System;

class IntOddEven
{
    static void Main()
    {
        Console.WriteLine("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        int b = 1;
        int c = a & b;
        if (c == 0) 
        {
            Console.WriteLine("The integer is even");
        }
        else 
        {
            Console.WriteLine("The integer is odd");
        }
    }
}

