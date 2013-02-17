using System;

class BitExchange
{
    static void Main()
    {
        Console.Write("Enter a positive number:");
        uint number = uint.Parse(Console.ReadLine());

        uint mask = 7;
        uint firstBits = (mask << 3) & number;
        uint secondBits = (mask << 24) & number;
        int push = 21;
        firstBits = firstBits << push;
        secondBits = secondBits >> push; 

        number = number & (~(mask << 3)); 
        Console.WriteLine(Convert.ToString(number, 2));

        number = number & (~(mask << 24)); 
        Console.WriteLine(Convert.ToString(number, 2));

        number = number | firstBits;
        Console.WriteLine(Convert.ToString(number, 2));

        number = number | secondBits; 
        Console.WriteLine(Convert.ToString(number, 2));
        Console.WriteLine("The new number is: {0}", number);
    }
}

