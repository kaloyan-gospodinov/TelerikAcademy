using System;

class StringObject
{
    static void Main()
    {
        string one = "Hello";
        string two = "World";
        object three = one + " " + two;
        string four = (string)three;
        Console.WriteLine(four);
    }
}

