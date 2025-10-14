using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int earnedPoints = _points;

        Console.WriteLine($"Congratulations! You earned {_points} points.");

        if (IsComplete())
        {
            earnedPoints += _bonus;
            Console.WriteLine($"You have completed the goal! You earned an extra {_bonus} bonus points!");
        }
        return earnedPoints;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete()? "[X]" : "[]";
        return $" {status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}