using System;

class PointCircleRect
{
    static void Main()
    {
        Console.Write("Enter x point:");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y point:");
        double y = double.Parse(Console.ReadLine());

        bool incircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= (3*3);
        bool inrectangle = ((-1 <= x) && (x <= 5)) && ((-1 <= y) && (y <= 1));
        Console.Write("The point is ");
        Console.Write(incircle ? "within the circle and " : "outside of the circle and ");
        Console.WriteLine(inrectangle ? "within the rectangle." : "outside of the rectangle.");
    }
}

