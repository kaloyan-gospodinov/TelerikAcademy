using System;

class BankAccount
{
    static void Main()
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter middle name: ");
        string middleName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        object fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine("Account holder: " + fullName);

        Console.Write("Enter money balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        string currency = "leva";
        Console.WriteLine("Balance: " + balance + " " + currency);

        Console.Write("Enter bank name: ");
        string bankName = Console.ReadLine();
        Console.WriteLine("Bank: " + bankName);

        Console.Write("Enter IBAN number: ");
        string iban = Console.ReadLine();
        Console.WriteLine("IBAN: " + iban);

        Console.Write("Enter Bic Code: ");
        string bicCode = Console.ReadLine();
        Console.WriteLine("BIC: " + bicCode);

        Console.Write("Enter first credit card number: ");
        ulong creditOne = ulong.Parse(Console.ReadLine());

        Console.Write("Enter second credit card number: ");
        ulong creditTwo = ulong.Parse(Console.ReadLine());

        Console.Write("Enter third credit card number: ");
        ulong creditThree = ulong.Parse(Console.ReadLine());
        Console.WriteLine("First Credit Card Number: " + creditOne);
        Console.WriteLine("Second Credit Card Number: " + creditTwo);
        Console.WriteLine("Third Credit Card Number: " + creditThree);
    }
}

