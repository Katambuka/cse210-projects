using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using Namespace2;

class SimpleGoal: GoalBase {
  private bool _completed;
  private string _completeMark;
  private string _goalName;
    private int _goalPoints;
  private readonly string _goalType;
  private readonly string _goalDescription;

  public SimpleGoal(string goalString) {
    _goalType = "SimpleGoal";
    string[] splitString = goalString.Split(',');
    _goalName = splitString[0];
    _goalDescription = splitString[1];
    _goalPoints = Int32.Parse(splitString[2]);
    _completed = bool.Parse(splitString[3]);
    if (_completed) {
      _completeMark = "X";
    } else {
      _completeMark = " ";
    }
  }

  public SimpleGoal(string goalName, string goalDescription, string goalPoints) {
    _goalName = goalName;
    _goalDescription = goalDescription;
    _goalPoints = Int32.Parse(goalPoints);
    _completed = false;
    _completeMark = " ";
    _goalType = "SimpleGoal";
  }
  new public void UpdateGoal() {
    _completed = true;
    _completeMark = "X";
  }
  public new int GetPoints() {
    int points = 0;
    if (_completed) {
      points = _goalPoints;
    }
    return points;
  }

  new public bool IsComplete() {
    return _completed;
  }
  new public string DisplayGoalInfo() {
    return " [" + _completeMark + "] " + _goalName + " (" + _goalDescription + ")";
  }
}