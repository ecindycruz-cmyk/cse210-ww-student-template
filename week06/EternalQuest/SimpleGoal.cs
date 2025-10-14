using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool IsComplete) : base (name, description, points)
    {
        _isComplete = IsComplete;
    }

    public override int RecordEvent()
    {
       if (_isComplete)
       {
        Console.WriteLine("This goal is already complete!");
        return 0;
       }
        _isComplete = true;
        Console.WriteLine($"Congratulations! You earned {_points} points.");
        return _points;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete? "[X]" : "[]";
        return $"{status} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}