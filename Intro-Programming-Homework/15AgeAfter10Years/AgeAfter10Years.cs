using System;

// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class AgeAfter10Years
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter your birthday in the format 'dd.mm.yyyy': ");
        DateTime myBirthday = DateTime.Parse(Console.ReadLine()); // using DateTime format to set the date
        long myAge = DateTime.Today.Subtract(myBirthday).Ticks; // using Subtract() method to subtract birth year and current year
        Console.WriteLine("You are now {0} years old.", new DateTime(myAge).Year - 1);
        Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(myAge).AddYears(10).Year - 1); // using AddYears() method for adding years to myAge
    }
}