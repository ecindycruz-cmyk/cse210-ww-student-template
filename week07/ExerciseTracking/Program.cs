using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Exercise Tracker ---");
        Console.WriteLine("Base Unit of Measurement: Kilometers (km)");
        Console.WriteLine("-------------------------------------------\n");

        List<Activity> activities = new List<Activity>();

        // Create instances
        activities.Add(new Running(
            new DateTime(2022, 11, 3), 
            30, 
            4.8));

        activities.Add(new Cycling(
            new DateTime(2022, 11, 4), 
            45, 
            25.0));

        activities.Add(new Swimming(
            new DateTime(2022, 11, 5), 
            20, 
            40));

        Console.WriteLine("Summary of Recorded Activities:\n");

        // Iterate and display summary
        foreach (var activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("Program finished.");
    }
}