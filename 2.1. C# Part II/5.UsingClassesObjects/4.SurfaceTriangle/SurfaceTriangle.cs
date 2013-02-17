using System;
using System.Collections.Generic;
using System.Linq;


class SurfaceTriangle
{
    static void Main()
    {

        //i)
        Console.Write("Enter side a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter altitude to it: ");
        int altitude = int.Parse(Console.ReadLine());
        Console.WriteLine("The surface is: {0}",((a*altitude)/2));
        Console.WriteLine();

        //ii)
        Console.Write("Enter side b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter side c: ");
        int c = int.Parse(Console.ReadLine());
        int p = ((a+b+c)/2);
        Console.WriteLine("The surface is: {0}", System.Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
        Console.WriteLine();

        //iii)
        Console.Write("Enter angle: ");
        int angle = int.Parse(Console.ReadLine());
        Console.WriteLine("The surface is: {0}", (((a) * (b) * (System.Math.Sin(angle))) / 2));




    }
}

