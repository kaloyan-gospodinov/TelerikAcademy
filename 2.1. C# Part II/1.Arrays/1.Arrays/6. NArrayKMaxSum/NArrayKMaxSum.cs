using System;
using System.Linq;


class NArrayKMaxSum
{
    static void Main()
    {
        Console.Write("Number Number N = ");
        int n = int.Parse(Console.ReadLine());


        Console.Write("Number Number K = ");
        int k = int.Parse(Console.ReadLine());


        if (k > n)
        {
            Console.WriteLine("The number K: {0} is bigger than N: {1}", k, n);
        }

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int bestSum = int.MinValue;
        int sum=0;
        int start = 0;

        for (int i = 0; i < n-k; i++)
        {
            for (int j = i; j < k + i; j++)
            {
                sum = sum + array[j];
            }

            if (sum > bestSum)
            {
                bestSum = sum;
                start = i;
            }
            sum = 0;
        }
        Console.WriteLine("The sum of the k({0}) largest numbers is: {1}", k,bestSum);
        Console.WriteLine("The max sum array starts at array index number: {0}",start);

        for (int i = start; i < start + k; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
    }
}

