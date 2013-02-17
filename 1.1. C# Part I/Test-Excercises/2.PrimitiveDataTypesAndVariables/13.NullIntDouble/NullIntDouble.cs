using System;

class NullIntDouble
{
    static void Main()
    {
        int? one = null;
        Console.WriteLine(one);

        double? two = null;
        Console.WriteLine(two);

        Console.WriteLine(one + 5);
        Console.WriteLine(two + 10);

        Console.WriteLine(one + null);
        Console.WriteLine(two + null);

        one = 28;
        Console.WriteLine(one.GetValueOrDefault());

        two = 36;
        Console.WriteLine(two.GetValueOrDefault());
    }
}

