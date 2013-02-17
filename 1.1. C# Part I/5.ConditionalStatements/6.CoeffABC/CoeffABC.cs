using System;



class CoeffABC
{
    static void Main()
    {
        Console.WriteLine("The equation structure: axx+bx+c=0");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double d; //d - discriminant
        double x1;
        double x2;

        d = (b * b) - (4 * a * c);

        if (d < 0)
        {
            Console.WriteLine("No solutions for the equation!");
        }

        else if (d == 0)
        {
            x1 = x2 = -b / (2 * a);
            Console.WriteLine("Both solutions are {0}.", x1);
        }
        else
        {
            x1 = (-b - Math.Sqrt(d)) / (2 * a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("The solutions are x1 = {0} and x2 = {1}.", x1, x2);
        }
    }
}

