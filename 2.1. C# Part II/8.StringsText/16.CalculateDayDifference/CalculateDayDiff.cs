using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateDayDiff
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first date: ");
        string dateOne = Console.ReadLine();
        Console.WriteLine("Enter second date: ");
        string dateTwo = Console.ReadLine();

        DateTime dateValue = DateValueOne(dateOne);

        DateTime dateValueTwo = DateValueTwo(dateTwo);


        TimeSpan time = TimeSpan(dateValue, dateValueTwo);


        int differenceInDays = time.Days;

        Console.WriteLine("Difference in days is: {0} ", differenceInDays);
      

    }

    private static DateTime DateValueOne(string dateOne)
    {
        DateTime dateValue = new DateTime();

        try
        {
            dateValue = DateTime.Parse(dateOne);

        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to convert '{0}'.", dateOne);
        }
        return dateValue;
    }

    private static DateTime DateValueTwo(string dateTwo)
    {
        DateTime dateValueTwo = new DateTime();
        try
        {
            dateValueTwo = DateTime.Parse(dateTwo);

        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to convert '{0}'.", dateTwo);
        }
        return dateValueTwo;
    }

    private static TimeSpan TimeSpan(DateTime dateValue, DateTime dateValueTwo)
    {
        TimeSpan time = new TimeSpan();

        if (dateValue > dateValueTwo)
        {
            time = (dateValue - dateValueTwo);
        }
        else if (dateValue < dateValueTwo)
        {
            time = (dateValueTwo - dateValue);
        }
        return time;
    }


}

