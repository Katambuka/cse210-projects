using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity(DateTime.Now, 30, 3.0);
        activities.Add(running);

        CyclingActivity cycling = new CyclingActivity(DateTime.Now, 45, 15.0);
        activities.Add(cycling);

        SwimmingActivity swimming = new(DateTime.Now, 60, 20);
        activities.Add(swimming);

        Console.WriteLine("\nMy Fitness Activity Tracker Program:");
        Console.WriteLine("**************************************");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.ReadKey();
    }
}
