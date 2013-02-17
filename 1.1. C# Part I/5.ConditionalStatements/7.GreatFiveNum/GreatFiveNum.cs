using System;



class GreatFiveNum
{
    static void Main()
    {
        Console.Write("Please, enter first number: ");
        double first = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        double second = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        double third = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fourth number: ");
        double fourth = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fifth number: ");
        double fifth = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(Math.Max(Math.Max(Math.Max(first, second), third), fourth), fifth));
    }
}
