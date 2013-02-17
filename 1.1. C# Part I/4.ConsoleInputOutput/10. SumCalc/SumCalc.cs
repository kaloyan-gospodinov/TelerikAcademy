using System;


class SumCalc
{
    static void Main()
    {
        decimal oldSum = 1M;
        decimal newSum = 1M;
        decimal denominator = 2M;
        decimal sumDiff;

        do
        {
            oldSum = newSum;

            if (denominator % 2 == 0)
            {
                newSum += ((decimal)1 / denominator);
            }
            else
            {
                newSum -= ((decimal)1 / denominator);
            }

            denominator++;
            sumDiff = (decimal)Math.Abs(newSum - oldSum);

        } while (sumDiff >= 0.001M);

        Console.WriteLine("The sum is {0:0.000}", newSum);
    }
}


