using System;
using System.Linq;


class ReverseDigit
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(ReversingNumbers(number));
    }

    static int ReversingNumbers(int number)
    {   
        while (number > 9)
        {
            Console.Write(number % 10);
            number = number/10;
        }
        return number;
    }

}

