using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


class NFactorial
{
    static BigInteger Factorial(BigInteger i)
    {
        if (i == 0) return 1;
        else return i * Factorial(i - 1);
    }

    static void Main()
    {


        for (int i = 1; i <101 ; i++)
        {
            Console.WriteLine("Factorial of {0} is: {1}",i,Factorial(i));
        }
        

    }
}

