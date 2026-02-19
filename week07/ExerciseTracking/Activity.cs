using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate() => _date;
    public int GetMinutes() => _minutes;

    // Abstract calculation methods
    public abstract double GetDistance();   // miles
    public abstract double GetSpeed();      // mph
    public abstract double GetPace();       // min per mile

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():F2} miles, " +
               $"Speed {GetSpeed():F2} mph, " +
               $"Pace: {GetPace():F2} min per mile";
    }
}
