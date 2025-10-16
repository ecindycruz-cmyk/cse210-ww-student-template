using System;
using System.Collections.Generic;
using System.Globalization;

public class Cycling : Activity
{
    //attribute for Cycling
    private double _initialSpeedKph;
    

     // Constructor
    public Cycling(DateTime date, int durationMinutes, double initialSpeedKph)
    : base(date, durationMinutes)
    {
        _initialSpeedKph = initialSpeedKph;
    }
     //Getters and Setters
    public double GetInitialSpeedKph()
    {
        return _initialSpeedKph;
    }

    public void SetInitialSpeedKph(double initialSpeedKph)
    {
        _initialSpeedKph = initialSpeedKph;
    }

    //Overriding Calculation Methods
    public override double GetDistanceKm()
    {
        return (GetInitialSpeedKph() * GetDurationMinutes()) / 60;
    }

    public override double GetSpeedKph()
    {
        return GetInitialSpeedKph();
    }

    public override double GetPaceMinPerKm()
    {
        if (GetInitialSpeedKph() == 0) return 0;
        return 60 / GetInitialSpeedKph();
    }
}