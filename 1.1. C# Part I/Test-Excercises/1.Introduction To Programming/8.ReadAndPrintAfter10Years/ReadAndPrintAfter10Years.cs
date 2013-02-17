using System;


class ReadAndPrintAfter10Years
{
    static void Main()
    {
        Console.Write("Enter Age:");
        string age = Console.ReadLine();
        int ageTen = int.Parse(age);
        ageTen += 10;
        Console.Write("Your age after ten years will be: ");
        Console.Write(ageTen);
        Console.WriteLine(" years old");
    }
}

