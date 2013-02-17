using System;


class TwoIntVar
{
    static void Main()
    {
        int one = 5;
        int two = 10;
        int tempo = 0; 
        
        tempo = one;
        one = two;
        two = tempo;
        Console.WriteLine(one);
        Console.WriteLine(two);
    }
}

