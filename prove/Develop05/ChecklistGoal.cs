// Checklist goal class where user must complete goal a certain number of times to earn bonus points
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int count;
    private string v;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        this.targetCount = targetCount;
        count = 0;
    }

    // Increment count and return points earned, or bonus points if target is reached
    public int Increment()
    {
        count++;
        if (count == targetCount)
        {
            count = 0;
            return Points + 100; // Bonus points for completing checklist
        }
        else
        {
            return Points;
        }
    }

    public override string DisplayProgress()
    {
        return string.Format("{0} (completed {1}/{2} times)", Name, count, targetCount);
    }

    internal override void AddEvent(string description, double value)
    {
        throw new NotImplementedException();
    }
}
