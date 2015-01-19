using System;

// A bank account has a holder name (first name, middle name and last name),
// available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account
// using the appropriate data types and descriptive names.

class BankAccount
{
    static void Main(string[] args)
    {
        string firstName = "Axel";
        string middleName = "Slav";
        string lastName = "Ivanov";
        object holderName = firstName + " " + middleName + " " + lastName;
        decimal accountBalance = 123.45M;
        string bankName = "Axel Union";
        string accountIBAN = "BGN01FFIB98765456789098";
        ulong creditCardNumber1 = 9876543210123456;
        ulong creditCardNumber2 = 9269873483755642;
        ulong creditCardNumber3 = 9126324836848568;
        Console.WriteLine("The customer name for this account is " + holderName);
        Console.WriteLine("The balance for this account is {0}", accountBalance);
        Console.WriteLine("The name of the bank for this account is " + bankName);
        Console.WriteLine("The IBAN for this account is " + accountIBAN);
        Console.WriteLine("The first credit card number for this account is {0}", creditCardNumber1);
        Console.WriteLine("The second credit card number for this account is {0}", creditCardNumber2);
        Console.WriteLine("The third credit card number for this account is {0}", creditCardNumber3);
    }
}
