using System;

abstract class Event
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public TimeSpan Duration { get; set; }
    public Address Address { get; set; }
    protected Type EventType { get; }

    public Event(string name, string description, DateTime startDate, TimeSpan duration, Address address, Type eventType)
    {
        this.Name = name;
        this.Description = description;
        this.StartDate = startDate;
        this.Duration = duration;
        this.Address = address;
        this.EventType = eventType;
    }

    public virtual string GetFullDetails()
    {
        return $"{this.Name}\n{this.Description}\n{this.StartDate}\n{this.Duration}\n{this.Address.GetFullAddress()}\nType of Event: {EventType.Name}";
    }

    public abstract string GetShortDescription();
}
