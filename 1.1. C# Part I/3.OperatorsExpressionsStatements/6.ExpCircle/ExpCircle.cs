using System;

class ExpCircle
{
    static void Main()
    {
        Console.Write("Enter x point:");
        double x = int.Parse(Console.ReadLine());

        Console.Write("Enter y point:");
        double y = int.Parse(Console.ReadLine());

        double squared = ((x*x)+(y*y));
        int circle = 5*5;

        if (squared > circle)
        {
            Console.WriteLine("The ({0}, {1}) points entered are outside the cirlce K(0,5)", x,y);
        }
        else
        {
            Console.WriteLine("The ({0}, {1}) points entered are inside the cirlce K(0,5)", x, y);
        }

    }
}

