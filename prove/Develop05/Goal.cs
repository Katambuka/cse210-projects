using System;
using System.Collections.Generic;

// Base class for all goals
public abstract class Goal
{
    private string name;
    private int points;
    private bool completed;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        completed = false;
    }

    public string Name { get { return name; } }
    public int Points { get { return points; } }
    public bool Completed { get { return completed; } }

    // Mark goal as completed and return points earned
    public int Complete()
    {
        completed = true;
        return points;
    }

    // Reset goal to not completed
    public void Reset()
    {
        completed = false;
    }

    // Abstract method for displaying goal progress
    public abstract string DisplayProgress();

    internal void RecordEvent(Event @event)
    {
        throw new NotImplementedException();
    }

    internal ReadOnlySpan<char> Serialize()
    {
        throw new NotImplementedException();
    }

    internal static Goal Deserialize(string line)
    {
        throw new NotImplementedException();
    }
}
