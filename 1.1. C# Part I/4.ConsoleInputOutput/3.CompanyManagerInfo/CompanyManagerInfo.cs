using System;


class CompanyManagerInfo
{
    static void Main()
    {
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company Phone Number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Company Fax Number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Company Web Site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Company Manager: ");
        string companyManager = Console.ReadLine();

        Console.Write("Manager First Name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager Last Name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Manager Phone Number: ");
        string managerPhoneNumber = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine("The Company's Name: {0,-20} | Address: {1,10:F2} |", companyName, companyAddress);
        Console.WriteLine("Telephone Number: {0,-20} |  Fax Number: {1,10:F2} |", companyPhoneNumber, companyFaxNumber);
        Console.WriteLine("Company Web Site: {0,-02} |  Company Manager: {1,10:F2} |", companyWebSite, companyManager);
       

        Console.WriteLine();
        Console.WriteLine("The Manager's First Name: {0,-02} | Last Name: {1,10:F2} |", managerFirstName, managerLastName);
        Console.WriteLine("Age: {0,-20} | Telephone Number: {1,10:F2} |", managerAge, managerPhoneNumber);  
        
    }
        
}

