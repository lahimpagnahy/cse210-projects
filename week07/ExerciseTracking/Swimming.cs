using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapDistanceInMeters = 50;
    private const double MetersToMiles = 0.00062137;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Convert laps to miles: laps * 50 meters per lap * meters to miles conversion
        return _laps * LapDistanceInMeters * MetersToMiles;
    }

    public override double GetSpeed()
    {
        // Speed in mph = (distance / minutes) * 60
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace in minutes per mile = minutes / distance
        return Minutes / GetDistance();
    }
}