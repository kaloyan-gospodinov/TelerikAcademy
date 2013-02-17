using System;

class FloatCompare
{
    static void Main()
    {
        Console.WriteLine("Enter two floating-point numbers.");
        Console.Write("1st Number: ");
        decimal inputOne = decimal.Parse(Console.ReadLine());
        Console.Write("2nd Number: ");
        decimal inputTwo = decimal.Parse(Console.ReadLine());
        inputOne = Math.Round(inputOne, 6);
        inputTwo = Math.Round(inputTwo, 6);
        bool equalOrNot = (inputOne == inputTwo);
        Console.WriteLine("Is there equality: {0}", equalOrNot);
    }
}