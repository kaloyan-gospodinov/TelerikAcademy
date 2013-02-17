using System;



class TwoIntIf
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers (on separate lines):");

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int switchNumber = firstNumber;
        

        if (firstNumber > secondNumber)
        {
            firstNumber = secondNumber;
            secondNumber = switchNumber;
           
            Console.WriteLine("The first number is: {0}", firstNumber);
            Console.WriteLine("The second number is: {0}", secondNumber);

        }
        else
        {
            Console.WriteLine("The second number is bigger");
        }

        
    }
}

