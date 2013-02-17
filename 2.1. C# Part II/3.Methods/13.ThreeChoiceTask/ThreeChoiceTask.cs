using System;
using System.Collections.Generic;
using System.Linq;


class ThreeChoiceTask
{   


    public static void Main()
    {
        Console.WriteLine("1-reverses number, 2- average, 3 equation a * x + b = 0");
        Console.Write("Enter number 1-3:");
        int number = int.Parse(Console.ReadLine());

        if (number == 1)
        {
            Console.Write("Enter number: ");
            int value = int.Parse(Console.ReadLine());

            if (value > 0)
            {
                Console.WriteLine(ReversingNumbers(value));
            }
            else
            {
                Console.WriteLine("You've entered a negative number or zero!");
            }
        }

        else if (number == 2)
        {
            Console.Write("Number of integers = ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            

            for (int i = 0; i < size; i++)
            {
                Console.Write("arr[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The average is: {0}",Average(array)); 
        }

        else if (number == 3)
        {
            Console.WriteLine("Equation coefficients");

            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter b:");
            double b = double.Parse(Console.ReadLine());

            if (a == 0.0 && b != 0.0)
            {
                Console.WriteLine("Invalid numbers for the equation! When a=0 => b=0.");
            }
            else if (a == 0.0 && b == 0.0)
            {
                Console.WriteLine("Every x is solution to the equation.");
            }
            else
            {
                double result = SolveEquation(a, b);
                Console.WriteLine("The root x = {0}", result);
            }

        }

        else
        {
            Console.WriteLine("You've entered a number different than 1, 2 or 3");
        }
    }

    static double SolveEquation(double a, double b)
    {
        double result = -b / a;
        return result;
    }

    static double Average(int[] array)
    {

        double average = array.Average();

        return average;
    }

    static int ReversingNumbers(int number)
    {
        while (number > 9)
        {
            Console.Write(number % 10);
            number = number / 10;
        }
        return number; 
    }

    
   
}

