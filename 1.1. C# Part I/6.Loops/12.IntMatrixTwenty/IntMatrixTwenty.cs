using System;


class IntMatrixTwenty
{
    static void Main()
    {
        int matrix = 0;

        Console.Write("Enter matrix size: ");
        string number = (Console.ReadLine());
        int n = Int32.Parse(number);
        bool isNumber = Int32.TryParse(number, out matrix);
        Console.WriteLine();

        if (n < 20)
        {   
            for (int rows = 1; rows <= matrix; rows++)
            {
                Console.WriteLine();

                for (int col = rows; col < rows + matrix; col++)
                {
                    Console.Write("{0,3} ", col);
                }

                Console.WriteLine();
            }
        }
        else if (n >= 20)
        {
            Console.WriteLine("You've entered a number bigger/equal to 20 !");
        }
    }
}

