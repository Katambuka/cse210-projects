using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;

namespace Namespace4 {
  // This class inherits from Namespace2.GoalBase and represents a checklist goal
  class ChecklistGoal: Namespace2.GoalBase {
    // These variables hold information about the goal and its progress
    protected int _finishingTimes; // how many times the goal needs to be completed
    protected int _timesCompleted; // how many times the goal has been completed so far
    protected int _bonusPoints; // bonus points awarded for completing the goal
    private string _goalType; // type of goal
    private readonly string _goalName; // name of the goal
    private readonly string _goalDescription; // description of the goal
    private readonly int _goalPoints; // points awarded for completing the goal
    private string _completeMark; // a mark to indicate if the goal is completed

    // This constructor takes a string in the format "name,description,points,bonus,finishing_times,times_completed" and initializes the goal
    public ChecklistGoal(string goalString) {
      _goalType = "ChecklistGoal";
      string[] splitString = goalString.Split(',');
      _goalName = splitString[0];
      _goalDescription = splitString[1];
      _goalPoints = Int32.Parse(splitString[2]);
      _bonusPoints = Int32.Parse(splitString[3]);
      _finishingTimes = Int32.Parse(splitString[4]);
      _timesCompleted = Int32.Parse(splitString[5]);
      // If the goal has been completed, mark it as such
      if (_timesCompleted == _finishingTimes) {
        _completeMark = "X";
      } else {
        _completeMark = " ";
      }
    }

    // This constructor takes individual parameters to initialize the goal
    public ChecklistGoal(string goalName, string goalDescription, string goalPoints, string finishedTimes, string bonusPoints) {
      _goalName = goalName;
      _goalDescription = goalDescription;
      _goalPoints = Int32.Parse(goalPoints);
      _finishingTimes = Int32.Parse(finishedTimes);
      _bonusPoints = Int32.Parse(bonusPoints);
      _completeMark = " ";
      _goalType = "ChecklistGoal";
      _timesCompleted = 0;
    }

    // This method updates the progress of the goal by incrementing the number of times it has been completed
    public new virtual void UpdateGoal() {
      _timesCompleted++;
      // If the goal has been completed, mark it as such
      if (_timesCompleted == _finishingTimes) {
        _completeMark = "X";
      }
    }

    // This method returns the total number of points awarded for completing the goal
    public new int GetPoints() {
      int points = 0;
      // If the goal has been completed, award bonus points in addition to the base points
      if (_timesCompleted == _finishingTimes) {
        points = _bonusPoints;
      }
      return points + _goalPoints;
    }

    // This method returns a boolean indicating whether the goal has been completed
    public new bool IsComplete() {
      return _timesCompleted == _finishingTimes;
    }

    // This method returns the total number of points awarded for the goal, taking into account how many times it has been completed
    public int GetLoadedPoints() {
      int points = 0;
      // If the goal has been completed,
      if (_timesCompleted == _finishingTimes) {
        points = _bonusPoints;
      }
      return points + (_goalPoints * _timesCompleted);
    }
    new public virtual string GetSaveGoal() {
      return _goalType + ":" + _goalName + "," + _goalDescription + "," + _goalPoints + "," + _bonusPoints + "," + _finishingTimes + "," + _timesCompleted;
    }

    new public string DisplayGoalInfo() {
      return " [" + _completeMark + "] " + _goalName + " (" + _goalDescription + ") -- Currently Completed: " + _timesCompleted + "/" + _finishingTimes;
    }
  }
}