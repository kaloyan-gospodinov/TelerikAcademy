using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecHexPercent
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15}", num); 

        Console.WriteLine("{0,15:X}", num); 

        Console.WriteLine("{0,15:P}", num); 

        Console.WriteLine("{0,15:E}", num); 

    }
}

