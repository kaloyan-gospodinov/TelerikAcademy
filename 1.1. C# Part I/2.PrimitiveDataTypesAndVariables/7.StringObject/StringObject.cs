using System;

class StringObject
{
    static void Main()
    {
        string hello = "Hello";
        Console.WriteLine(hello);

        string world = "World";
        Console.WriteLine(world);

        object helloWorld = hello + " " + world;
        Console.WriteLine(helloWorld);

        string helloWorldString = (string)helloWorld;
        Console.WriteLine(helloWorldString);

    }
}

