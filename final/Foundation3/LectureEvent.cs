using System;
class LectureEvent : Event
{
    public string SpeakerName { get; set; }
    public int Capacity { get; set; }

    public LectureEvent(string name, string description, DateTime startDate, TimeSpan duration, Address address, string speakerName, int capacity)
        : base(name, description, startDate, duration, address, typeof(LectureEvent))
    {
        this.SpeakerName = speakerName;
        this.Capacity = capacity;
    }

    public override string GetShortDescription()
    {
        return $"{this.Name}: {this.Description}";
    }
}