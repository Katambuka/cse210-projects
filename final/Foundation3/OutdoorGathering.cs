using System;
class OutdoorGatheringEvent : Event
{
    public string WeatherDescription { get; set; }

    public OutdoorGatheringEvent(string name, string description, DateTime startDate, TimeSpan duration, Address address, string weatherDescription)
        : base(name, description, startDate, duration, address, typeof(OutdoorGatheringEvent))
    {
        this.WeatherDescription = weatherDescription;
    }

    public override string GetShortDescription()
    {
        return $"{this.Name}: {this.Description}";
    }
}