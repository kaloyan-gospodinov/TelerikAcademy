using System;



class SignThreeRealNum
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers (on separate lines):");

        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product of the three numbers is: 0");
        }

        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0) 
        {
            Console.WriteLine("The sign of the product of the entered numbers is (-) negative");
        }

        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product of the entered numbers is (-) negative");
        }

        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product of the entered numbers is (-) negative");
        }

        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product of the entered numbers is (-) negative");
        }

        else
        {
            Console.WriteLine("The sign of the product of the entered numbers is (+) positive");
        }
    }
}

