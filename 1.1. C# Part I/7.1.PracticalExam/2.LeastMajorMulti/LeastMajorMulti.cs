using System;

class LeastMajorMulti
{
    static void Main()
    {
        
        uint a = uint.Parse(Console.ReadLine());

        uint b = uint.Parse(Console.ReadLine());

        uint c = uint.Parse(Console.ReadLine());

        uint d = uint.Parse(Console.ReadLine());

        uint e = uint.Parse(Console.ReadLine());

        for (int i = 1; true; i++)
        {
            int count = 0;
            if (i % a == 0)
            {
                count++;
            }
            if (i % b == 0)
            {
                count++;
            }
            if (i % c == 0)
            {
                count++;
            }
            if (i % d == 0)
            {
                count++;
            }
            if (i % e == 0)
            {
                count++;
            }
            if (count >= 3)
            {
                Console.WriteLine(i);
                break;
            }
        }
        
    }
}

