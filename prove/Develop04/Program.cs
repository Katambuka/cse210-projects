using System;
using System.Threading;
using MindfulnessApp;

// The entry point for the program.
// Displays a menu of activities and prompts the user to choose one.
// Then, prompts the user to enter a duration and begins the selected activity for that duration.
// The program loops until the user chooses to quit.
Console.WriteLine("Welcome to Mindfulness App!");
while (true)
{
    // Display the menu of activities.
    Console.WriteLine("Please choose an activity:");
    Console.WriteLine("1. Breathing Activity");
    Console.WriteLine("2. Reflection Activity");
    Console.WriteLine("3. Listing Activity");
    Console.WriteLine("4. Quit");

    // Get user input and validate it.
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int choice) || choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid input. Please choose a number from 1 to 4.");
        continue;
    }

    // If the user chose to quit, exit the program.
    if (choice == 4)
    {
        Console.WriteLine("Thank you for using Mindfulness App!");
        break;
    }

    // Prompt the user to enter a duration for the activity.
    Console.Write("Enter duration in seconds: ");
    int duration;
    while (!int.TryParse(Console.ReadLine(), out duration) || duration < 1)
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
    }

    // Prepare to start the activity.
    string[] spinner = { "/", "-", "\\", "|" };
    int index = 0;
    for (int i = 3; i >= 1; i--)
    {
        Console.Write("Prepare to begin in ");
        Console.Write(spinner[index]);
        Console.CursorLeft--;
        index = (index + 1) % spinner.Length;
        Thread.Sleep(1000);
        Console.Clear();
    }
    Console.WriteLine("Go!");

    // Start the selected activity.
    switch (choice)
    {
        case 1:
            // Create a new instance of the BreathingActivity class and start the activity.
            var breathingActivity = new Namespace2.BreathingActivity();
            breathingActivity.StartActivity(duration);
            break;
        case 2:
            // Create a new instance of the ReflectionActivity class and start the activity.
            var reflectionActivity = new Namespace3.ReflectionActivity();
            reflectionActivity.StartActivity(duration);
            break;
        case 3:
            // Create a new instance of the ListingActivity class and start the activity.
            var listingActivity = new ListingActivity();
            listingActivity.StartActivity(duration);
            break;
    }

    // The activity has ended.
    Console.WriteLine("Good job! You have completed the activity.");
    Console.WriteLine();
}
