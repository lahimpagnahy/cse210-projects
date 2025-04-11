using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        List<Activity> activities = new List<Activity>();

        // Create a running activity (date, minutes, distance in miles)
        Running running = new Running(
            new DateTime(2022, 11, 3),
            30,
            3.0);
        activities.Add(running);

        // Create a cycling activity (date, minutes, speed in mph)
        Cycling cycling = new Cycling(
            new DateTime(2022, 11, 4),
            45,
            15.0);
        activities.Add(cycling);

        // Create a swimming activity (date, minutes, number of laps)
        Swimming swimming = new Swimming(
            new DateTime(2022, 11, 5),
            30,
            20);
        activities.Add(swimming);

        // Display summary for each activity
        Console.WriteLine("Exercise Tracking Program");
        Console.WriteLine("=======================");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}