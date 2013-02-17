using System;

class PQBitExchange
{
    static void Main()
    {
        Console.Write("Please enter a positive number to exchange bits: ");
        uint input = uint.Parse(Console.ReadLine());

        Console.Write("p= ");
        byte pos1 = byte.Parse(Console.ReadLine());

        Console.Write("q= ");
        byte pos2 = byte.Parse(Console.ReadLine());

        Console.Write("k= ");
        byte length = byte.Parse(Console.ReadLine());

        uint number1Add = ((input << (32 - pos2 - length)) >> (32 - length)) << pos1;
        uint number2Add = ((input >> pos1) << (32 - length)) >> (32 - pos2 - length);
        uint numberToAdd = number1Add + number2Add;

        uint number1Subtract = number1Add << (pos2 - pos1);
        uint number2Subtract = number2Add >> (pos2 - pos1);
        uint numberToSubtract = number1Subtract + number2Subtract;

        uint output = (input - numberToSubtract) + numberToAdd;

        Console.WriteLine("The result is: " + output);
    }
}

