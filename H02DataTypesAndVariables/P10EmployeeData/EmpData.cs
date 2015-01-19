using System;

// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// First name
// Last name
// Age (0...100)
// Gender (m or f)
// Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
// Use descriptive names. Print the data at the console.

class EmpData
{
    static void Main(string[] args)
    {
        string firstName = "Axel";
        string lastName = "Ivanov";
        byte age = 25;
        char gender = 'f';
        long personalIDNumber = 9876543210;
        int uniqueEmployeeNumber = 27560000;
        Console.WriteLine("The first name of the employee is: {0}", firstName);
        Console.WriteLine("The last name of the employee is: {0}", lastName);
        Console.WriteLine("The age of the employee is {0}", age);
        Console.WriteLine("The gender of the employee is " + gender);
        Console.WriteLine("The Personal ID number of the employee is {0}", personalIDNumber);
        Console.WriteLine("The Unique employee number of the employee is {0}", uniqueEmployeeNumber);
    }
}
