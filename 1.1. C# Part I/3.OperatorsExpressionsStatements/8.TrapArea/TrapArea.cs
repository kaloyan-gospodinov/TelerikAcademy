using System;

    class TrapArea
    {
        static void Main()
        {
            Console.Write("Enter side a:");
            decimal aside = decimal.Parse(Console.ReadLine());

            Console.Write("Enter side b:");
            decimal bside = decimal.Parse(Console.ReadLine());

            Console.Write("Enter height h:");
            decimal hheight = decimal.Parse(Console.ReadLine());

            decimal area = ((aside + bside) * hheight) / (2);
            Console.WriteLine("The area of the trapezoid is = {0}", area);
        }
    }
