using System;

class BoolBitThree
{
    static void Main()
    {
        Console.Write("Enter int: ");
        int number = int.Parse(Console.ReadLine());
        bool exp;

        int p = 2;            
        int mask = 1 << p;        
        int nAndMask = number & mask;  
        int bit = nAndMask >> p;
        if (bit == 0)
        {
            exp = true;
            Console.WriteLine("The third bit is 0: {0}", exp);
        }
        else if (bit == 1)
        {
            exp = false;
            Console.WriteLine("The third bit is 0: {0}", exp);
        } 

    }
}

