using System;
using System.Threading;

Console.WriteLine("Welcome to Mindfulness App!");

while (true)
{
    Console.WriteLine("Please choose an activity:");
    Console.WriteLine("1. Breathing Activity");
    Console.WriteLine("2. Reflection Activity");
    Console.WriteLine("3. Listing Activity");
    Console.WriteLine("4. Quit");

    string input = Console.ReadLine();
    if (!int.TryParse(input, out int choice) || choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid input. Please choose a number from 1 to 4.");
        continue;
    }

    if (choice == 4)
    {
        Console.WriteLine("Thank you for using Mindfulness App!");
        break;
    }

    Console.Write("Enter duration in seconds: ");
    int duration;
    while (!int.TryParse(Console.ReadLine(), out duration) || duration < 1)
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
    }

    Console.WriteLine("Prepare to begin in:");
    for (int i = 3; i >= 1; i--)
    {
        Console.WriteLine(i);
        Thread.Sleep(1000);
    }
    Console.WriteLine("Go!");

    switch (choice)
    {
        case 1:
            BreathingActivity(duration);
            break;
        case 2:
            ReflectionActivity(duration);
            break;
        case 3:
            ListingActivity(duration);
            break;
    }

    Console.WriteLine("Good job! You have completed the activity.");
    Console.WriteLine();
}

void ListingActivity( int duration)
{
    throw new NotImplementedException();
}

void BreathingActivity(int duration)
{
    Console.WriteLine("Breathing Activity: This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

    for (int i = 0; i < duration; i += 2)
    {
        Console.WriteLine("Breathe in...");
        Thread.Sleep(1000);
        Console.WriteLine("Breathe out...");
        Thread.Sleep(1000);
    }
}

void ReflectionActivity(int duration)
{
    Console.WriteLine("Reflection Activity: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    Random random = new();
    while (duration > 0)
    {
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(3000);
        }
    }
}
