using System;

class NullIntDouble
{
    static void Main()
    {
        int? nullInt = null;
        Console.WriteLine(nullInt);

        double? nullDouble = null;
        Console.WriteLine(nullDouble);

        Console.WriteLine(nullInt + 12);
        Console.WriteLine(nullDouble + 14);

        nullInt = 28;
        Console.WriteLine(nullInt.GetValueOrDefault());

        nullDouble = 36;
        Console.WriteLine(nullDouble.GetValueOrDefault());
    }
}

