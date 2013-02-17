using System;



class NPrintNum
{
    static void Main()
    {
        Console.Write("Enter value: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;

        for (i = 1; i <= n; i++)
        {
            Console.Write("{0}, ", i); 
        }
        
    }
}

