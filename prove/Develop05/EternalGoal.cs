using System;
using System.Collections.Generic;

// Eternal goal class where user earns points every time they mark goal as complete
public class EternalGoal : Goal
{
    private int count;

    public string V { get; }

    public EternalGoal(string name, int points) : base(name, points)
    {
        count = 0;
    }
    // Increment count and return points earned
    public int Increment()
    {
        count++;
        return Points;
    }

    public override string DisplayProgress()
    {
        return string.Format("{0} (completed {1} times)", Name, count);
    }

    internal override void AddEvent(string description, double value)
    {
        throw new NotImplementedException();
    }
}
