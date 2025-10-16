using System;
using System.Collections.Generic;
using System.Globalization;

//abstract base class for all activities.

public abstract class Activity
{
    // (private) attributes
    private DateTime _date;
    private int _durationMinutes;

    protected const double MetersPerKm = 1000;
    protected const double PoolLengthMeters = 50;

    // Base class constructor
    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    // Getter for the date
    public DateTime GetDate()
    {
        return _date;
    }

    // Setter for the date
    public void SetDate(DateTime date)
    {
        _date = date;
    }

    // Getter for the duration in minutes
    public int GetDurationMinutes()
    {
        return _durationMinutes;
    }

    // Setter for the duration in minutes
    public void SetDurationMinutes(int durationMinutes)
    {
        if (durationMinutes >= 0)
        {
            _durationMinutes = durationMinutes;
        }
    }

    public abstract double GetDistanceKm();
    public abstract double GetSpeedKph();
    public abstract double GetPaceMinPerKm();

    
    // GetSummary
    
    public string GetSummary()
    {
        // I use GetDate() and GetDurationMinutes() to access private data
        //  I Use InvariantCulture for a standard English date format
        string formattedDate = GetDate().ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        string activityName = this.GetType().Name;

        double distance = GetDistanceKm();
        double speed = GetSpeedKph();
        double pace = GetPaceMinPerKm();

        // Format the output
        return string.Format(
            "{0} {1} ({2} min): Distance {3:F1} km, Speed: {4:F1} kph, Pace: {5:F2} min per km",
            formattedDate,
            activityName,
            GetDurationMinutes(),
            distance,
            speed,
            pace
        );
    }
}
