using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("My first Project for C#!");
        Console.WriteLine("What is your nick-name?");
        string name = Console.ReadLine();
        Console.WriteLine("What is your first name? ");
        string FastName = Console.ReadLine();
        Console.WriteLine($"My first name is {FastName}");
        Console.WriteLine("What is your last name? ");
        string LastName = Console.ReadLine();
        Console.WriteLine($"My name is {name}");
        Console.WriteLine($"My Last name is {LastName}");
        Console.WriteLine($"My names are {name},{FastName} {LastName}.");
    }
}