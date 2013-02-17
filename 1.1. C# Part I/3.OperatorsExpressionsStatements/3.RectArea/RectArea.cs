using System;

class RectArea
{
    static void Main()
    {
        Console.Write("Enter width: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double b = double.Parse(Console.ReadLine());

        double area = a * b;

        Console.WriteLine("The rectangle's area is: {0}", (area));
    }
}

