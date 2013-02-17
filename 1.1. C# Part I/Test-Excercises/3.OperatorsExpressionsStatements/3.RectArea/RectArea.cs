using System;

class RectArea
{
    static void Main()
    {
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;

        Console.WriteLine("The rectanble's area is: {0}", area);

    }
}

