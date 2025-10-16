using System;
using System.Collections.Generic;
using System.Globalization;

public class Running : Activity
{
    //attribute for Running
    private double _initialDistanceKm;

    // Constructor
    public Running(DateTime date, int durationMinutes, double initialDistanceKm)
        : base(date, durationMinutes)
    {
        _initialDistanceKm = initialDistanceKm;
    }

    // Getters and Setters

    public double GetInitialDistanceKm()
    {
        return _initialDistanceKm;
    }

    public void SetInitialDistanceKm(double initialDistanceKm)
    {
        _initialDistanceKm = initialDistanceKm;
    }

    //Overriding Calculation Methods

    public override double GetDistanceKm()
    {
        return GetInitialDistanceKm();
    }

    public override double GetSpeedKph()
    {
        if (GetDurationMinutes() == 0) return 0;
        // Speed (kph) = (Distance / Minutes) * 60
        return (GetDistanceKm() / GetDurationMinutes()) * 60;
    }

    public override double GetPaceMinPerKm()
    {
        if (GetDistanceKm() == 0) return 0;
        // Pace (min/km) = Minutes / Distance
        return GetDurationMinutes() / GetDistanceKm();
    }
}
