using System;


class ReadIntMinMax
{
    static void Main()
    {
        Console.Write("Enter number of integer numbers: ");
        int nintegers = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 1; i <= nintegers; i++)
        {
            Console.Write("Enter {0} number: ", i);
            int number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine("The minimal number is: {0}", min);
        Console.WriteLine("The maximal number is: {0}", max);
           
    }
}

