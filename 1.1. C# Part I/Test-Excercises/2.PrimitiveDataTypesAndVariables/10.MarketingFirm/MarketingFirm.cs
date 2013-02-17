using System;


class MarketingFirm
{
    static void Main()
    {

        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter family name: ");
        string familyName = Console.ReadLine();

        Console.Write("Enter age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.Write("Enter gender - m/f: ");
        char gender = char.Parse(Console.ReadLine());
        if (gender == 'm' || gender == 'f')
        {
            Console.Write("Enter id number: ");
            int idNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Unique employee number: ");
            int uniqueEmNum = int.Parse(Console.ReadLine());
            if (27560000 <= uniqueEmNum && uniqueEmNum <=27569999)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}, Gender: {3}, Id Number: {4}, \nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, uniqueEmNum);
            }
            else
            {
                Console.WriteLine("You have entered a different value for Unique employee number different from the range 27560000 - 27569999");
            }
        }
        else
        {
            Console.WriteLine("You have entered a different value for gender than m/f");
        }
    }
}

