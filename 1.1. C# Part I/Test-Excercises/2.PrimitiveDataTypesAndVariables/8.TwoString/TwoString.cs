using System;


class TwoString
{
    static void Main()
    {
        string one = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(one);

        string two = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(two);
    }
}

