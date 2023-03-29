using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

public partial class Program
{
    public static void Main()
    {
        goals = new List<Goal>();
        int totalpoints = 0;
        ShowMenu();
    }

    private static void ShowMenu()
    {
        int score = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("-------------\n");

            Console.WriteLine("Goals:");
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.DisplayProgress());
                if (goal.Completed)
                {
                    score += goal.Complete();
                }
            }

            Console.WriteLine("\nScore: {0}\n", score);

            Console.WriteLine("Options:");
            Console.WriteLine("1. Add new goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Save goals to file");
            Console.WriteLine("4. Load goals from file");
            Console.WriteLine("5. Quit");

            switch (GetChoice(1, 5))
            {
                case 1:
                    AddNewGoal(goals);
                    break;

                case 2:
                    RecordEvent(goals);
                    break;

                case 3:
                    SaveGoals(goals);
                    break;

                case 4:
                    LoadGoals(goals);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    private static void LoadGoals(List<Goal> goals)
    {
        throw new NotImplementedException();
    }

    private static void SaveGoals(List<Goal> goals)
    {
        throw new NotImplementedException();
    }

    private static List<Goal> goals;

    int totalpoints;

    private static int GetChoice(int min, int max)
    {
        while (true)
        {
            Console.Write("Enter your choice ({0}-{1}): ", min, max);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= min && choice <= max)
            {
                return choice;
            }

            Console.WriteLine("Invalid input. Please enter a number between {0} and {1}.", min, max);
        }
    }

    private static void AddNewGoal(List<Goal> goals)
    {
        Console.WriteLine("\nWhat type of goal do you want to add?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        string response = Console.ReadLine();

        int choice = int.Parse(response);

        Console.Write("\nEnter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the target value: ");
        int targetValue = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                goals.Add(new SimpleGoal(name, targetValue));
                break;

            case 2:
                goals.Add(new EternalGoal(name, targetValue));
                break;

            case 3:
                Console.Write("Enter the number of items on the checklist: ");
                int numItems = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, targetValue, numItems));
                break;
        }

        Console.WriteLine("\nGoal added!");
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }
    private static void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("\nWhich goal would you like to record an event for?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, goals[i].Name);
            }
            int choice = GetChoice(1, goals.Count);
            Console.Write("Enter a description of the event: ");
            string description = Console.ReadLine();

            Console.Write("Enter the value of the event: ");
            double value = GetDouble();

            goals[choice - 1].AddEvent(description, value);
            Console.WriteLine("Event recorded for {0}.\n", goals[choice - 1].Name);
            Console.Write("Enter the date of the event (yyyy-MM-dd): ");
            DateTime date = GetDateInput("Enter the date of the event (yyyy-MM-dd): ");


            goals[choice - 1].RecordEvent(new Event(description, value, date));

           Console.WriteLine("\nEvent recorded!");
    Console.Write("Press Enter to continue...");
    Console.ReadLine();
    }

    private static double GetDouble()
    {
        throw new NotImplementedException();
    }

    private static int GetIntInput(string message)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            return value;
        }
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

private static DateTime GetDateInput(string message)
{
    while (true)
    {
        Console.Write(message);
        if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            return date;
        }
        Console.WriteLine("Invalid input. Please enter a valid date in the format yyyy-MM-dd.");
    }
}
}