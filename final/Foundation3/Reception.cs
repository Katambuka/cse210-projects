using System;
class ReceptionEvent : Event
{
    public string RSVPContact { get; set; }

    public ReceptionEvent(string name, string description, DateTime startDate, TimeSpan duration, Address address, string rsvpContact)
        : base(name, description, startDate, duration, address, typeof(ReceptionEvent))
    {
        this.RSVPContact = rsvpContact;
    }

    public override string GetShortDescription()
    {
        return $"{this.Name}: {this.Description}";
    }
}
