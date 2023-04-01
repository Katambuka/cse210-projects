public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int length, int laps)
        : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (length / 60.0);
    }

    public override double GetPace()
    {
        return length / GetDistance();
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return string.Format("{0} Swimming ({1} min) - Distance: {2:0.00} km, Speed: {3:0.00} km/h, Pace: {4:0.00} min/km",
            date.ToShortDateString(), length, distance, speed, pace);
    }
}