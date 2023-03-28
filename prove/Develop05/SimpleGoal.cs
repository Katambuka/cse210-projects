using System;
using System.Collections.Generic;

// Simple goal class where user marks goal as complete and earns points
public class SimpleGoal : Goal
{

    public SimpleGoal(string name, int points) : base(name, points) { }

    public override string DisplayProgress()
    {
        return Completed ? "[X] " + Name : "[ ] " + Name;
    }
}
