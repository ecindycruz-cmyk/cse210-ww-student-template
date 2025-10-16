using System;
using System.Collections.Generic;
using System.Globalization;

public class Swimming : Activity
{
    //attribute for Swimming
    private int _numberOfLaps;

    // Constructor
    public Swimming(DateTime date, int durationMinutes, int numberOfLaps)
        : base(date, durationMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    //Getters and Setters

    public int GetNumberOfLaps()
    {
        return _numberOfLaps;
    }

    public void SetNumberOfLaps(int numberOfLaps)
    {
        _numberOfLaps = numberOfLaps;
    }

    //Overriding Calculation Methods

    public override double GetDistanceKm()
    {
        // Distance (km) = (Laps * 50 meters) / 1000 meters/km
        return (GetNumberOfLaps() * PoolLengthMeters) / MetersPerKm;
    }

    public override double GetSpeedKph()
    {
        if (GetDurationMinutes() == 0) return 0;
        return (GetDistanceKm() / GetDurationMinutes()) * 60;
    }

    public override double GetPaceMinPerKm()
    {
        if (GetDistanceKm() == 0) return 0;
        return GetDurationMinutes() / GetDistanceKm();
    }
}

