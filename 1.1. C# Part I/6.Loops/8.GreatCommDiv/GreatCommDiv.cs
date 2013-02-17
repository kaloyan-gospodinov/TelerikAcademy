using System;


class GreatCommDiv
{
    static void Main()
    {
        Console.Write("Enter A = ");
        string numberOne = Console.ReadLine();
        long A = int.Parse(numberOne);

        Console.Write("Enter B = ");
        string numberTwo = Console.ReadLine();
        long B = int.Parse(numberTwo);

        long c;
        long gcd;

        if (A == 0 && B > 0)
        {
            gcd = B;
            Console.WriteLine("The GCD is {0}.", gcd);

        }
        else if (B == 0 && A > 0)
        {
            gcd = A;
            Console.WriteLine("The GCD is {0}.", gcd);
        }
        else if (A > 0 && B > 0)
        {
            while (B > 0)
            {
                c = B;
                B = A % B;
                A = c;
            }

            gcd = A;

            Console.WriteLine("The GCD is {0}.", gcd);
        }
        
    }
}

