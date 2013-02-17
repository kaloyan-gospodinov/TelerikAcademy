using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year = ReadVariable();
            CheckLeap(year);
        }

        private static int ReadVariable()
        {
            Console.Write("Enter year to be checked: ");
            int year = int.Parse(Console.ReadLine());
            return year;
        }

        private static void CheckLeap(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
        }
    }
}
