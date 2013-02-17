using System;
using System.Numerics;


class NFactMultKFact
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInputOne = Console.ReadLine();
        int n = Convert.ToInt32(consoleInputOne);

        Console.Write("k = ");
        string consoleInputTwo = Console.ReadLine();
        int k = Convert.ToInt32(consoleInputTwo);

        BigInteger factorialOne = 1;
        BigInteger factorialTwo = 1;
        BigInteger factorialThree = 1;

        if (n < k && n > 1)
        {
            for (int i = 1; i <= n; i++)
            {
                factorialOne *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                factorialTwo *= j;
            }
            Console.WriteLine("N! = {0}", factorialOne);
            Console.WriteLine("K! = {0}", factorialTwo);

            for (int l = 1; l <= (k - n); l++)
            {
                factorialThree *= l;
            }
            Console.WriteLine("(K-N)! = {0}", factorialThree);

            Console.WriteLine("N!*K! = {0}", factorialOne * factorialTwo);
            Console.WriteLine("N!*K!/(K-N)! = {0}", (factorialOne * factorialTwo)/factorialThree);

        }
        else
        {
            Console.WriteLine("The second number - k, should be bigger than - n!");
        }
    }
}

