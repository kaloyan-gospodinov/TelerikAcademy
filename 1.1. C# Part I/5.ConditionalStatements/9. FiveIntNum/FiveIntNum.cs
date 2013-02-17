using System;


class FiveIntNum
{
    static void Main()
    {
        Console.Write("Please, enter first number: ");
        double first = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        double second = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        double third = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fourth number: ");
        double fourth = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fifth number: ");
        double fifth = double.Parse(Console.ReadLine());

        // 2 digits ===============================================================================

        if (first + second == 0)
        {
            Console.WriteLine("First: {0} + Second: {1} = 0", first, second);    
        }
        else if (first + third == 0)
        {
            Console.WriteLine("First: {0} + Third: {1} = 0", first, third);    
        }
        else if (first + fourth == 0)
        {
            Console.WriteLine("First: {0} + Fourth: {1} = 0", first, fourth);
        }
        else if (first + fifth == 0)
        {
            Console.WriteLine("First: {0} + Fifth: {1} = 0", first, fifth);
        }
        else if (second + third == 0)
        {
            Console.WriteLine("Second: {0} + Third: {1} = 0", second, third);
        }
        else if (second + fourth == 0)
        {
            Console.WriteLine("Second: {0} + Fourth: {1} = 0", second, fourth);
        }
        else if (second + fifth == 0)
        {
            Console.WriteLine("Second: {0} + Fifth: {1} = 0", second, fifth);
        }
        else if (third + fourth == 0)
        {
            Console.WriteLine("Third: {0} + Fourth: {1} = 0", third, fourth);
        }
        else if (third + fifth == 0)
        {
            Console.WriteLine("Third: {0} + Fifth: {1} = 0", third, fifth);
        }
        else if (fourth + fifth == 0)
        {
            Console.WriteLine("Fourth: {0} + Fifth: {1} = 0", fourth, fifth);
        }

        // 3 digits ===============================================================================

        else if (first + second + third == 0)
        {
            Console.WriteLine("First: {0} + Second: {1} + Third: {2} = 0", first, second, third);
        }
        else if (first + second + fourth == 0)
        {
            Console.WriteLine("First: {0} + Second: {1} + Fourth: {2} = 0", first, second, fourth);
        }
        else if (first + second + fifth == 0)
        {
            Console.WriteLine("First: {0} + Second: {1} + Fifth: {2} = 0", first, second, fifth);
        }
        else if (first + third + fourth == 0)
        {
            Console.WriteLine("First: {0} + Third: {1} + Fourth: {2} = 0", first, third, fourth);
        }
        else if (first + third + fifth == 0)
        {
            Console.WriteLine("First: {0} + Third: {1} + Fifth: {2} = 0", first, third, fifth);
        }
        else if (first + fourth + fifth == 0)
        {
            Console.WriteLine("First: {0} + Fourth: {1} + Fifth: {2} = 0", first, fourth, fifth);
        }
        else if (second + third + fourth == 0)
        {
            Console.WriteLine("Second: {0} + Third: {1} + Fourth: {2} = 0", second, third, fourth);
        }
        else if (second + third + fifth == 0)
        {
            Console.WriteLine("Second: {0} + Third: {1} + Fifth: {2} = 0", second, third, fifth);
        }
        else if (second + fourth + fifth == 0)
        {
            Console.WriteLine("Second: {0} + Fourth: {1} + Fifth: {2} = 0", second, fourth, fifth);
        }
        else if (third + fourth + fifth == 0)
        {
            Console.WriteLine("Third: {0} + Fourth: {1} + Fifth: {2} = 0", third, fourth, fifth);
        }

        // 4 digits ===============================================================================

        else if (first + second + third + fourth== 0)
        {
            Console.WriteLine("First: {0} + Second: {1} + Third: {2} + Fourth: {3} = 0", first, second, third, fourth);
        }
        else if (first + second + third + fifth == 0)
        {
            Console.WriteLine("First: {0} + Second: {1} + Third: {2} + Fifth: {3} = 0", first, second, third, fifth);
        }
        else if (first + second + fourth + fifth == 0)
        {
            Console.WriteLine("First: {0} + Second: {1} + Fourth: {2} + Fifth: {3} = 0", first, second, fourth, fifth);
        }
        else if (first + third + fourth + fifth == 0)
        {
            Console.WriteLine("First: {0} + Third: {1} + Fourth: {2} + Fifth: {3} = 0", first, third, fourth, fifth);
        }
        else if (second + third + fourth + fifth == 0)
        {
            Console.WriteLine("Second: {0} + Third: {1} + Fourth: {2} + Fifth: {3} = 0", second, third, fourth, fifth);
        }

        // 5 digits ===============================================================================

        else if (first + second + third + fourth + fifth == 0)
        {
            Console.WriteLine("First: {0} + Second: {1} + Third: {2} + Fourth: {3} + Fifth: {4} = 0", first, second, third, fourth, fifth);
        }
        
    }
}

