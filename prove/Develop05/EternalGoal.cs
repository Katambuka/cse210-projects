
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Threading;
using Namespace2;

namespace Namespace3
{
    class EternalGoal : GoalBase
    {
        protected int _timesCompleted;
        private string _goalName;
        private string _goalDescription;
        private readonly int _goalPoints;
        private readonly string _completeMark;
        private string _goalType;
        public EternalGoal(string goalString)
        {
            _goalType = "EternalGoal";
            string[] splitString = goalString.Split(',');
            _goalName = splitString[0];
            _goalDescription = splitString[1];
            _goalPoints = Int32.Parse(splitString[2]);
        }

        public EternalGoal(string goalName, string goalDescription, string goalPoints)
        {
            _goalName = goalName;
            _goalDescription = goalDescription;
            _goalPoints = Int32.Parse(goalPoints);
            _completeMark = " ";
            _goalType = "EternalGoal";

            _timesCompleted = 0;
        }

        new public void UpdateGoal()
        {
            _timesCompleted++;
        }
        public new int GetPoints()
        {
            return _goalPoints;
        }
        public static new bool IsComplete()
        {
            return false;
        }
        public int GetLoadedPoints()
        {
            return _goalPoints * _timesCompleted;
        }
        public string GetSaveGoal()
        {
            return _goalType + ":" + _goalName + "," + _goalDescription + "," + _goalPoints;
        }
        public new string DisplayGoalInfo()
        {
            return " [ ] " + _goalName + " (" + _goalDescription + ")";
        }
    }
}