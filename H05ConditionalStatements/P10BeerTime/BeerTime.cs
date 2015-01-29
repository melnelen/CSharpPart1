//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
//a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
//according to the definition above or invalid time if the time cannot be parsed. 
//Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;

class BeerTime
{
    static void Main(string[] args)
    {
        try
        {
            CultureInfo myLocalTime = CultureInfo.InvariantCulture;
            Console.Write("Please enter time in format \"hh:mm tt\": ");
            DateTime myTime = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", myLocalTime);

            //set starting and ending time
            DateTime startDrinking = DateTime.ParseExact("01:00 PM", "hh:mm tt", myLocalTime);
            DateTime stopDrinking = DateTime.ParseExact("03:00 AM", "hh:mm tt", myLocalTime);

            //check the time
            if (myTime >= startDrinking && myTime >= stopDrinking)
            {
                Console.WriteLine("It is beer time! :):):)");
            }
            else
            {
                Console.WriteLine("It is not beer time :(");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid time!");
        }
    }
}