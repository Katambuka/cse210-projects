using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("100 Main St", "Los Angeles", "CA", "90015");
        Address address2 = new Address("456 Oak Ave", "New York", "NY", "10001");
        Address address3 = new Address("789 Pine Rd", "Miami", "FL", "33101");

        Event[] events = {
            new LectureEvent("Modern Web Design", "Learn about the latest techniques and trends in web design", new DateTime(2023, 4, 10), new TimeSpan(9), address1, "James Web", 50),
            new ReceptionEvent("Company Anniversary Party", "Join us for a night of celebration and networking", new DateTime(2023, 5, 20), new TimeSpan(18), address2, "RSVP to events@company.com"),
            new OutdoorGatheringEvent("Family Picnic", "Enjoy a day of outdoor activities and food with your loved ones", new DateTime(2023, 6, 10, 10, 0, 0), TimeSpan.FromHours(2), address3, "Sunny skies ahead!")
        };

        // Call each method to generate the marketing messages and output their results to the screen

        Console.WriteLine("\nAddress:");
        Console.WriteLine("Event 1: " + address1.GetFullAddress());
        Console.WriteLine("Event 2: " + address2.GetFullAddress());
        Console.WriteLine("Event 3: " + address3.GetFullAddress());

        foreach (Event ev in events)
        {
            Console.WriteLine($"\n{ev.GetType().Name}:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine(ev.GetShortDescription());
        }
    }
}
