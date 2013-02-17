using System;



class TwoGreatNum
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}", Math.Max(first,second));
    }
}

