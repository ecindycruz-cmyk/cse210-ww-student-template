using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public int Points => _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}