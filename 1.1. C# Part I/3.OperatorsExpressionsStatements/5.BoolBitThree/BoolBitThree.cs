using System;

class BoolBitThree
{
    static void Main()
    {
        int p = 2;
        Console.Write("Enter number:");
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;

        bool exp;
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

