using System;

class TwoIntVar
{
    static void Main()
    {
        int firstVar;
        int secondVar;
        firstVar = 5;
        secondVar = 10;
        Console.WriteLine(firstVar);
        Console.WriteLine(secondVar);

        int tempVar = firstVar;
        firstVar = secondVar;
        secondVar = tempVar;
        Console.WriteLine(firstVar);
        Console.WriteLine(secondVar);
    }
}

