using System;

class MarketingFirm
{
    static void Main()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Family Name: ");
        string familyName = Console.ReadLine();

        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Gender (m or f): ");
        char? gender = char.Parse(Console.ReadLine());
        if (gender == 'm')
        {
            
        }
        else
        {
            if (gender == 'f')
            {
                
            }
            else
            {
                gender = null;
                Console.WriteLine("You've typed a wrong letter");
            }
        }

        Console.Write("Id Number: ");
        long idNumber = long.Parse(Console.ReadLine());


        Console.Write("Unique Employee Number: ");
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());
        if (27559999 < uniqueEmployeeNumber && uniqueEmployeeNumber < 27570000)
        {
            Console.WriteLine("Name: {0} {1}, Age: {2}, Gender: {3}, Id Number: {4}, \nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, uniqueEmployeeNumber);
        }
        else
        {
            uniqueEmployeeNumber = 0;
            Console.WriteLine("The number is different than the range of 27560000 - 27569999");
        }
    }
        
}
