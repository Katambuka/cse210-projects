internal class Event
{
    private string description;
    private int value;
    private DateTime date;

    public Event(string description, int value, DateTime date)
    {
        this.description = description;
        this.value = value;
        this.date = date;
    }

    public Event(string description, double value1, DateTime date)
    {
        this.description = description;
        Value = value1;
        this.date = date;
    }

    public double Value { get; }
}