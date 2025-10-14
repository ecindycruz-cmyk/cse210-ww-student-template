using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class EternalGoal : Goal
{
    private int _amountCompleted;


    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _amountCompleted = 0;
    }

    public EternalGoal(string name, string description, int points, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Congratulations! You earned {_points} points.");
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[∞]{_shortName} ({_description}) - Completed: {_amountCompleted}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}";
    }
}