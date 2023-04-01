public class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int length, double distance)
        : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (length / 60.0);
    }

    public override double GetPace()
    {
        return length / distance;
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return string.Format("{0} Running ({1} min) - Distance: {2:0.00} km, Speed: {3:0.00} km/h, Pace: {4:0.00} min/km",
            date.ToShortDateString(), length, distance, speed, pace);
    }
}