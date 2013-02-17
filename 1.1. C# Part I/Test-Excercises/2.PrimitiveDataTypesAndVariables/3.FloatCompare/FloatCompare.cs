using System;

class FloatCompare
{
    static void Main()
    {
        Console.WriteLine("Enter two floating-point numbers.");

        Console.Write("1st Number: ");
        double one = double.Parse(Console.ReadLine());
        one = Math.Round(one, 6);

        Console.Write("2nd Number: ");
        double two = double.Parse(Console.ReadLine());
        two = Math.Round(two, 6);

        if(one == two)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
        Console.WriteLine("{0}, {1}", one, two);
    }
}

