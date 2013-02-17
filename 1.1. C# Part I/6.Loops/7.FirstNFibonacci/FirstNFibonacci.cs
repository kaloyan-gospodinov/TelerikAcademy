using System;

class FirstNFibonacci
{
    static void Main()
    {
        Console.Write("Enter n = ");
        string numberAsString = Console.ReadLine();
        int n = int.Parse(numberAsString);

        ulong numberOne = 0;
        ulong numberTwo = 1;
        ulong numberThree = numberOne + numberTwo;
        ulong sum = numberOne + numberTwo + numberThree;

        if (n == 1)
        {
            Console.WriteLine("Sum = {0}", n-1);
        }
        else if (n == 2)
        {
            Console.WriteLine("Sum = {0}", n - 1);
        }
        else if (n == 3)
        {
            Console.WriteLine("Sum = {0}", n - 1);
        }
        else if (n > 3)

        {
            for (int i = 1; i <= n-3; i++)
            {
                numberOne = numberTwo;
                numberTwo = numberThree;
                numberThree = numberOne + numberTwo;
                sum = sum + numberThree;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }

        else if (n <= 0)
        {
            Console.WriteLine("The number was not positive");
        }

    }
}

