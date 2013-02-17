using System;

class ReadAndPrintAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter Age:");
        string line = Console.ReadLine();
        int age;
        int.TryParse(line, out age);
        Console.Write("Your age after ten years will be: ");
        Console.Write(age + 10);
        Console.WriteLine(" years old");
    }
}