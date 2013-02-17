using System;
using System.Collections.Generic;
using System.Linq;

class StringIntSum
{
    static void Main()
    {
        Console.Write("Enter numbers in a string: ");
        string input = Console.ReadLine() ;
        string[] stringNumbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int sum = stringNumbers.Select(int.Parse).Sum();

        Console.WriteLine("The sum is: {0}", sum);
    }
}

