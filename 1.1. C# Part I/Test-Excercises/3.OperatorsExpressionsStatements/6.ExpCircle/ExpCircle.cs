using System;

class ExpCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double numX = double.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        double numY = double.Parse(Console.ReadLine());

        double squared = ((numX * numX) + (numY * numY));
        int circle = 5*5;

        if ( squared <= circle)
        {
            Console.WriteLine("The values of x:{0} and y:{1} are inside the circle K(0,5) ", numX, numY);
        }
        else
        {
            Console.WriteLine("The values of x:{0} and y:{1} are outside the circle K(0,5) ", numX, numY);
        }
    }
}