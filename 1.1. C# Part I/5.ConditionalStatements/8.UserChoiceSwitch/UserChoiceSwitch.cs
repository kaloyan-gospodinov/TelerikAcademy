using System;



class UserChoiceSwitch
{
    static void Main()
    {
        Console.Write("Enter input - for int - 1, for double - 2 and for string - 3: ");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {

            case 1:
                Console.Write("Enter integer: ");
                int first = int.Parse(Console.ReadLine());
                first++;
                Console.WriteLine("The entered variable is: {0}", first);
                break;
            case 2:
                Console.Write("Enter double: ");
                double second = double.Parse(Console.ReadLine());
                second++; 
                Console.WriteLine("The entered variable is: {0}", second);
                break;
            case 3:
                Console.Write("Enter string: ");
                string third = Console.ReadLine();
                Console.WriteLine("The entered variable is: {0}*",third);
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}

