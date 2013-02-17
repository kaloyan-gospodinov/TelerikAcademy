using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class AddTwoPolynomials
{
    static void Main()
    {
        decimal[] first = new decimal[] { 1,2,3,4,5,6 };
        decimal[] second = new decimal[] { -1,-2,-3,-4 };

        Console.WriteLine("Polynomial 1: {0}", PrintPolynomial(first));
        Console.Write("Polynomial 2: {0}", PrintPolynomial(second));

        decimal[] sum = SumPolynomials(first, second);
        Console.WriteLine("\n" + "Sum: {0}", PrintPolynomial(sum));
    }


    
    private static decimal[] SumPolynomials(decimal[] first, decimal[] second)
    {
        decimal[] third = new decimal[Math.Max(first.Length, second.Length)];

        for (int i = 0; i < first.Length; i++)
        {
            third[i] = first[i];
        }

        for (int i = 0; i < second.Length; i++)
        {
            third[i] += second[i];
        }

        return third;
    }

    private static string PrintPolynomial(decimal[] polynomial)
    {
        StringBuilder returnString = new StringBuilder();

        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0)
            {
                returnString.Append(polynomial[i] > 0 ? " + " : " - ");
                returnString.Append(Math.Abs(polynomial[i]));
                if (i != 0)
                {
                    returnString.Append(i > 1 ? "x^" + i : "x");
                }
            }
        }

        if (returnString[1] != '-')
        {
            returnString.Remove(0, 3);
        }
        else
        {
            returnString.Remove(0, 1);
        }

        return returnString.ToString();
    }
   
}

