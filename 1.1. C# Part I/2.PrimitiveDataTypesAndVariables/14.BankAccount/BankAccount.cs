using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Kaloyan";
        string middleName = "Stefanov";
        string surName = "Gospodinov";
        object fullName = firstName + " " + middleName + " " + surName;
        Console.WriteLine("Account holder: " + fullName);

        decimal moneyBalance = 12131.99M;
        string currency = "leva";
        Console.WriteLine("Balance: " + moneyBalance + " " + currency);
         
        string bankName = "First Investment Bank";
        Console.WriteLine("Bank: " + bankName);

        string code = "BG";
        byte controlNumber = 16;
        string identificator = "FINV";
        long end = 56000071453210;
        object iban = (code + controlNumber + identificator + end);
        Console.WriteLine("IBAN: " + iban);

        string bic = "FINVBGSF";
        Console.WriteLine("BIC: " + bic);

        ulong firstCreditCard = 1234567891234567L;
        ulong secondCreditCard = 4567891234567891L;
        ulong thirdCreditCard = 7891234567891234L;

        Console.WriteLine("First Credit Card Number: " + firstCreditCard);
        Console.WriteLine("Second Credit Card Number: " + secondCreditCard);
        Console.WriteLine("Third Credit Card Number: " + thirdCreditCard);

    }
}

