using System;

// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company 
// and its manager and prints it back on the console.

class CompanyInfo
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the company name: ");
        string nameCompany = Console.ReadLine();
        Console.Write("Please enter the address of the company: ");
        string addresCompany = Console.ReadLine();
        Console.Write("Please enter phone number: ");
        string phoneNum = Console.ReadLine();
        Console.Write("Please enter the fax number: ");
        string faxNum = Console.ReadLine();
        Console.Write("Please enter the web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Please enter the first name of the Manager: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter the last name of the Manager: ");
        string lastName = Console.ReadLine();
        Console.Write("Please enter the age of the Manager: ");
        byte ageManager = byte.Parse(Console.ReadLine());
        Console.Write("Please enter the phone number of the Manager: ");
        string phoneManager = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(nameCompany);
        Console.WriteLine("Address: " + addresCompany);
        Console.WriteLine("Tel: " + phoneNum);
        Console.WriteLine("Fax: " + faxNum);
        Console.WriteLine("Web site: http://" + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel: {3})", firstName, lastName, ageManager, phoneManager);
    }
}
