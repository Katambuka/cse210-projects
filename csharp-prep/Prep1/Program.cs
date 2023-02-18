using System;
using Develop04;

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


// Create a new instance of a Car and set its properties
Car myCar = new()
{
    Model = "Benz",
    RegistrationDate = new DateTime(2021, 3, 15),
    Mileage = 10000
};

// Print the car's properties to the console
Console.WriteLine("Car Model: " + myCar.Model);
Console.WriteLine("Registration Date: " + myCar.RegistrationDate.ToString("yyyy-MM-dd"));
Console.WriteLine("Mileage: " + myCar.Mileage);

namespace Develop04
{
    class Car
    {
        public string Model { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Mileage { get; set; }
    }
}
