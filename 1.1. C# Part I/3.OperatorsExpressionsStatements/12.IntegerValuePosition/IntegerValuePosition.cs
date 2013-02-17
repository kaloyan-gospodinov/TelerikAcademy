using System;

class IntegerValuePosition
{
    static void Main()
    {
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter position:");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Enter value (1 or 0):");
        int value = int.Parse(Console.ReadLine());

        if (value == 1)
        {

            int mask = 1 << position;
            int result = number | mask;
            Console.WriteLine("The new result is: {0}", result);
            string bin = Convert.ToString(result, 2).PadLeft(32, '0');
            Console.WriteLine("The binary representation is: {0}", bin);

        }

        else
        {
            if (value == 0)
            {
                int mask = ~(1 << position);
                int result = number & mask;
                Console.WriteLine("The new result is {0}", result);
                string bin = Convert.ToString(result, 2).PadLeft(32, '0');
                Console.WriteLine("The binary representation is: {0}", bin);
            }
            else
            {
                Console.WriteLine("You have entered a value different of 1 or 0");
            }
        }
    }
}

