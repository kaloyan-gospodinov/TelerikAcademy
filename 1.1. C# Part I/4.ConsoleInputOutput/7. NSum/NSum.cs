using System;


class NSum
{
    static void Main()
    {   
        int i;
        Console.Write("Enter number of values: ");
        int n = int.Parse(Console.ReadLine());

        int number;
        int sum = 0;

        for (i = 0; i < n; i++)
        {
            Console.Write("Input number:");
            number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of all values is {0}", sum);
    }
}


