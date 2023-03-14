using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using Namespace2;
using Namespace3;

namespace Namespace {
  internal static class Program {
    public static void Main() {
      goals = new List < GoalBase > ();
      totalPoints = 0;
      ShowMenu();
    }
    private static List < GoalBase > goals;
    private static int totalPoints;

    public static void CreateNewGoal() {
      Console.WriteLine("The types of goals are: ");
      Console.WriteLine("1. Simple Goal: ");
      Console.WriteLine("2. Eternal Goal: ");
      Console.WriteLine("3. Checklist Goal: ");

      string response = Console.ReadLine();
      string goalName;
      string goalDescription;
      string goalPoints;

      if (response == "1") {
        Console.WriteLine("What is the name of the goal? ");
        goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal? ");
        goalDescription = Console.ReadLine();
        Console.WriteLine("How many points do you want associated with the goal?");
        goalPoints = Console.ReadLine();
        if (Int32.Parse(goalPoints) < 0) {
          Console.WriteLine("Try to only write positive goals!");
        } else {
          goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
      } else if (response == "2") {
        Console.WriteLine("What is the name of the goal? ");
        goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal? ");
        goalDescription = Console.ReadLine();
        Console.WriteLine("How many points do you want associated with the goal?");
        goalPoints = Console.ReadLine();
        if (Int32.Parse(goalPoints) < 0) {
          Console.WriteLine("Try to only write positive goals!");
        } else {
          goals.Add(new Namespace.EternalGoal(goalName, goalDescription, goalPoints));
        }
      } else if (response == "3") {
        string finishedTimes;
        string bonusPoints;

        Console.WriteLine("What is the name of the goal? ");
        goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of the goal? ");
        goalDescription = Console.ReadLine();
        Console.WriteLine("How many points do you want associated with the goal?");
        goalPoints = Console.ReadLine();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        finishedTimes = Console.ReadLine();
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        bonusPoints = Console.ReadLine();
        if (Int32.Parse(goalPoints) < 0 || Int32.Parse(bonusPoints) < 0) {
          Console.WriteLine("Try to only write positive goals!");
        } else {
          goals.Add(new Namespace4.ChecklistGoal(goalName, goalDescription, goalPoints, finishedTimes, bonusPoints));
        }
      } else {
        Console.WriteLine("That is not a valid Option, please insert a valid option");
      }
    }

    public static void ListGoals() {
      int goalNum = 1;
      Console.WriteLine("The goals are: ");
      foreach(GoalBase goal in goals) {
        Console.Write(goalNum + ". ");
        Console.WriteLine(goal.DisplayGoalInfo());
        goalNum++;
      }
    }

    public static void SaveGoalToFile() {
      Console.WriteLine("Enter a filename to save the goals to:");
      string filename = Console.ReadLine();
      using StreamWriter outputFile = new(filename);
      outputFile.WriteLine(totalPoints);
      foreach(GoalBase goal in goals) {
        outputFile.WriteLine(goal.GetSaveGoal());
      }
    }

    public static void LoadGoalFromFile() {
      Console.WriteLine("Enter a filename to load the goals from:");
      string filename = Console.ReadLine();

      string[] lines = System.IO.File.ReadAllLines(filename);

      goals.Clear();

      totalPoints = Int32.Parse(lines[0]);
      for (int iter = 1; iter < lines.Length; iter++) {
        string[] typeSplit = lines[iter].Split(':');

        if (typeSplit[0] == "SimpleGoal") {
          goals.Add(new SimpleGoal(typeSplit[1]));
        } else if (typeSplit[0] == "EternalGoal") {
          goals.Add(new EternalGoal(typeSplit[1]));
        } else if (typeSplit[0] == "ChecklistGoal") {
          goals.Add(new ChecklistGoal(typeSplit[1]));
        }

      }
    }

    public static void RecordEvent() {
      int goalNum = 1;
      Console.WriteLine("The goals are: ");
      foreach(GoalBase goal in goals) {
        Console.Write(goalNum + ". ");
        Console.WriteLine(goal.GetGoalName());
        goalNum++;
      }
      Console.WriteLine("Which goal did you accomplish?");
      int goalSelection = int.Parse(Console.ReadLine());
      goalSelection--;

      if (goalSelection >= 0 && goalSelection <= goals.Count) {
        if (goals[goalSelection].IsComplete()) {
          Console.WriteLine("You have already done this goal!");
        } else {
          goals[goalSelection].UpdateGoal();
          totalPoints += goals[goalSelection].GetPoints();
        }

      }
    }

   public static void ShowMenu() {
  string input = "";
  while (input != "7") {
    //_completedPoints = points;
    Console.WriteLine("Welcome to the Eternal Quest Program!");
    Console.WriteLine("1. Add new goal");
    Console.WriteLine("2. View goals");
    Console.WriteLine("3. Record an event");
    Console.WriteLine("4. View score");
    Console.WriteLine("5. Save goals");
    Console.WriteLine("6. Load goals");
    Console.WriteLine("7. Exit");
    Console.WriteLine();

    Console.WriteLine("Please select an option:");
    input = Console.ReadLine();

    if (input == "1") {
      CreateNewGoal();
    } else if (input == "2") {
      ListGoals();
    } else if (input == "3") {
      RecordEvent();
    } else if (input == "4") {
        ViewScore();
    } else if (input == "5") {
      SaveGoalsToFile();
    } else if (input == "6") {
      LoadGoalsFromFile();
    } else if (input == "7") {
      Console.WriteLine("Goodbye.");
    } else {
        Console.WriteLine("Invalid option. Please try again.");
        }
        }
        }

        private static void LoadGoalsFromFile()
        {
            throw new NotImplementedException();
        }

        private static void SaveGoalsToFile()
        {
            throw new NotImplementedException();
        }

        private static void ViewScore()
        {
            throw new NotImplementedException();
        }

        internal class ChecklistGoal: GoalBase {
    private readonly string v;

    public ChecklistGoal(string v) {
      this.v = v;
    }
  }
  }
  internal class EternalGoal: GoalBase {
    private string goalName;
    private string goalDescription;
    private string goalPoints;

    public EternalGoal(string v) {}

    public EternalGoal(string goalName, string goalDescription, string goalPoints) {
      this.goalName = goalName;
      this.goalDescription = goalDescription;
      this.goalPoints = goalPoints;
    }
  }
}