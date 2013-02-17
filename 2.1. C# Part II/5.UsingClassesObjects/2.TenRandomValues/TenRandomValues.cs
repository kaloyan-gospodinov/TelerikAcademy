using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TenRandomValues
{
    static void Main()
    {
        Random rand = new Random();
        for (int i = 1; i <= 10; i++)
        {
            int randomNumber = rand.Next(100) + 100;
            Console.Write("{0} ", randomNumber);
        }

    }
}

