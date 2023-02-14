using System;
using Develop04;

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
