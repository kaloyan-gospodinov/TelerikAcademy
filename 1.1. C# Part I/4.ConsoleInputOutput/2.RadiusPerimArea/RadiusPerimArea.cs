using System;

class RadiusPerimArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        double area;
        double perimeter;

        perimeter = (2 * (3.14) * (radius));
        area = ((3.14) * (radius) * (radius));

        Console.WriteLine("The perimeter is: {0} ", perimeter);
        Console.WriteLine("The area is: {0} ", area);
    }
}

