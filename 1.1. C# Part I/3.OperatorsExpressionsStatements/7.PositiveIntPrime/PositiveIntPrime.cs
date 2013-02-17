using System;

    class PositiveIntPrime
    {
        static void Main()
        {
            Console.Write("Enter integer bigger than 0 and smaller than 100:");
            int n = int.Parse(Console.ReadLine());
            int p = 0;

            if ((n >100) || (n<=0))
            {
                Console.WriteLine("You have entered an invalid number outside the required range.");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    double result = (n % i);
                    if (result == 0)
                    {
                        p ++;
                    }  
                }

                Console.WriteLine(p <= 1 ? "It is a prime number" : "It is not a prime number"); 
            }

        }
    }

