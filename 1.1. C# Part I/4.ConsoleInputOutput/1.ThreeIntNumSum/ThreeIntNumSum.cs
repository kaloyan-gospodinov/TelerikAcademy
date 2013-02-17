using System;

class ThreeIntNumSum
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());
        int sum = first + second + third;
        Console.WriteLine("The sum is: {0} ", sum);
    }
}

