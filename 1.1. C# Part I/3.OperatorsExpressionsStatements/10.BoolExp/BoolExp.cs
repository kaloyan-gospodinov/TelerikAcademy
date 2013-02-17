using System;

class BoolExp
{
    static void Main()
    {

        Console.Write("Enter integer:");
        int integer = int.Parse(Console.ReadLine());

        Console.Write("Enter position:");
        int position = int.Parse(Console.ReadLine());
        
        int mask = 1 << position;        
        int nAndMask = integer & mask;  
        int bit = nAndMask >> position;  

        bool exp;
        if (bit == 1)
        {
            exp = true;
            Console.WriteLine("The bit at position {0} from number {1} has value of 1: {2}", position, integer, exp);
        }
        else
        {
            exp = false;
            Console.WriteLine("The bit at position {0} from number {1} has value of 1: {2}", position, integer, exp);
        }
    }
}

