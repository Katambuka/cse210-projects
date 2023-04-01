public class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int length, double speed)
        : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return GetSpeed() * (length / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / GetSpeed();
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return string.Format("{0} Cycling ({1} min) - Distance: {2:0.00} km, Speed: {3:0.00} km/h, Pace: {4:0.00} min/km",
            date.ToShortDateString(), length, distance, speed, pace);
    }
}