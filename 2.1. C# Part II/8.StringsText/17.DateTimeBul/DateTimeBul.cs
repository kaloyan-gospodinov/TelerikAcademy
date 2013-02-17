using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DateTimeBul
{
    static void Main()
    {
        Console.WriteLine("Enter full lenght date and time = \"dd.MM.yyyy HH:mm:ss\"");
        DateTime dateValue = new DateTime();
        string dateString = "16.02.2008 12:15:12";

        try
        {
            dateValue = DateTime.ParseExact(dateString, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to convert '{0}'.", dateString);
        }
        dateValue = dateValue.AddHours(6.5);
        string dayOfWeek = dateValue.ToString("dddd", new CultureInfo("bg-BG"));
        dayOfWeek = char.ToUpper(dayOfWeek[0]) + dayOfWeek.Substring(1);

        Console.WriteLine("{0} {1}", dayOfWeek, dateValue);
    }
}

