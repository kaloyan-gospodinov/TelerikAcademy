using System;



class BigThreeInt
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers (on separate lines).");

        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        if (first ==  second && third == second)
        {  
            Console.WriteLine("The three numbers are equal");
        }

        else if (first == second)
        {
            Console.WriteLine("The first two numbers are equal.");

            if (second > third)
            {
                Console.WriteLine("The biggest number is: {0}", second);
            }

            else if (third > second)
            {
                Console.WriteLine("The biggest number is: {0}", third);
            }

            
        }

        else if (second == third)
        {
            Console.WriteLine("The second and third numbers are equal.");

            if (second > first)
            {
                Console.WriteLine("The biggest number is: {0}", second);
            }

            else if (first > second)
            {
                Console.WriteLine("The biggest number is: {0}", first);
            }
        }

        else if (first == third)
        {
            Console.WriteLine("The first and third numbers are equal.");

            if (second > third)
            {
                Console.WriteLine("The biggest number is: {0}", second);
            }

            else if (third > second)
            {
                Console.WriteLine("The biggest number is: {0}", third);
            }
        }

        else if (first > second)
        {
            if (first > third)
            {
                Console.WriteLine("The first number is the biggest.");
            }

            else if (first < third)
            {
                Console.WriteLine("The third number is the biggest.");
            }
        }

        else if (first < second)
        {
            if (second > third)
            {
                Console.WriteLine("The second number is the biggest.");
            }

            else if (second < third)
            {
                Console.WriteLine("The third number is the biggest.");
            }
        }

        else if (third > second)
        {
            if (first > third)
            {
                Console.WriteLine("The first number is the biggest.");
            }

            else if (first < third)
            {
                Console.WriteLine("The third number is the biggest.");
            }
        }

        else if (first > third)
        {
            if (first > second)
            {
                Console.WriteLine("The first number is the biggest.");
            }

            else if (first < second)
            {
                Console.WriteLine("The second number is the biggest.");
            }
        }
    }
}

