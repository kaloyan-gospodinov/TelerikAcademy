using System;

class TwoString
{
    static void Main()
    {
        string first = @"The ""use"" of quotations causes dificulties.";
        Console.WriteLine(first);

        string second = "The \"use\" of quotations causes dificulties.";
        Console.WriteLine(second);
    }
}
