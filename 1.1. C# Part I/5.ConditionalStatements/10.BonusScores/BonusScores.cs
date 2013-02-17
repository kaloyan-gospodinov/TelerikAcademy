using System;



class BonusScores
{
    static void Main()
    {
        Console.Write("Enter a score number in the range [1..9]: ");

        uint digit = uint.Parse(Console.ReadLine());

        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                digit = (10 * digit);
                Console.WriteLine("The score including the bonus is: {0}", digit);
                break;
            case 4:
            case 5:
            case 6:
                digit = (100 * digit);
                Console.WriteLine("The score including the bonus is: {0}", digit);
                break;
            case 7:
            case 8:
            case 9:
                digit = (1000* digit);
                Console.WriteLine("The score including the bonus is: {0}", digit);
                break;
            default:
                Console.WriteLine("Error! Number not in the range!");
                break;
        }
    }
}

