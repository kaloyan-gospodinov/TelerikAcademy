using System;



class DescSortThreeNum
{
    static void Main()
    {
        Console.WriteLine("Please, enter first number: ");
        double first = double.Parse(Console.ReadLine());

        Console.WriteLine("Please, enter second number: ");
        double second = double.Parse(Console.ReadLine());

        Console.WriteLine("Please, enter third number: ");
        double third = double.Parse(Console.ReadLine());


        if (first > second)
        {
            if (first > third)
            {
                if (second > third)
                {
                    Console.WriteLine("The order is: {0}, {1}, {2}", first, second, third);
                }
                else
                {
                    Console.WriteLine("The order is: {0}, {1}, {2}", first, third, second);
                }
            }
            else
            {
                Console.WriteLine("The order is: {0}, {1}, {2}", third, first, second);
            }
        }

        else if (second > third)
        {
            if (first > third)
            {
                Console.WriteLine("The order is: {0}, {1}, {2}", second, first, third);
            }    
            else 
            {
                Console.WriteLine("The order is: {0}, {1}, {2}", second, third, first);
            }

        }
        else
        {
            Console.WriteLine("The order is: {0}, {1}, {2}", third, second, first);
        }
        

    }
}

