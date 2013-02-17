using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WorkDays
{
    static void Main()
    {


        Console.Write("Enter date in DD/MM/YYYY format: ");
        string date = Console.ReadLine();

        DateTime today = DateTime.Today;
        DateTime endDay = DateTime.Parse(date);
        int span = (endDay - today).Days;
        
        Console.WriteLine();

        
        Console.WriteLine("The calendar days are: {0}",span);
        Console.WriteLine();
        //Console.WriteLine("There're {0} days between {1} and {2}", span, d1.ToString(), d2.ToString());

        if (endDay < today)
        {
            Console.WriteLine("You've entered a date smaller than today's!");
        }

        double workDays = 1 + ((endDay - today).TotalDays * 5 - (today.DayOfWeek - endDay.DayOfWeek) * 2) / 7;

        if ((int)endDay.DayOfWeek == 6)
        {
            workDays--;
        }

        if ((int)today.DayOfWeek == 0)
        {
            workDays--;
        }

        Console.WriteLine("The working days are: {0}",workDays);
        Console.WriteLine();


        DateTime[] holidays = new DateTime[]
        {
            new DateTime(today.Year, 1, 1),
            new DateTime(today.Year, 3, 3),
            new DateTime(today.Year, 5, 1),
            new DateTime(today.Year, 5, 2),
            new DateTime(today.Year, 5, 6),
            new DateTime(today.Year, 5, 24),
            new DateTime(today.Year, 9, 22),
            new DateTime(today.Year, 12, 24),
            new DateTime(today.Year, 12, 25),
            new DateTime(today.Year, 12, 26),
            new DateTime(today.Year, 12, 31)
        };

        foreach (DateTime holiday in holidays)
        {
            DateTime holi = holiday.Date;
            if (today <= holi && holi <= endDay)
            {
                --workDays;
            }
        }

        Console.WriteLine("The working days minus holidays are: {0}",workDays);
        Console.WriteLine();
    }
    

        

    
      
      
    
}

