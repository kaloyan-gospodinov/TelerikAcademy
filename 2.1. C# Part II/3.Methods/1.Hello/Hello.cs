using System;
using System.Collections.Generic;
using System.Linq;

class Hello
{
    static void PrintName()
    {

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}",name);
        
    }


    static void Main()
    {
        PrintName();
    }
}

