using System;
using System.Collections.Generic;

/* Brigham Young University–Idaho
   Olubisi Ayantoye
  W07 Prove: Final Foundation—Inheritance and Polymorphism
       */

// Base Activity Class
public abstract class Activity
{
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Properties to access private members
    public DateTime Date { get { return _date; } }
    public int Duration { get { return _duration; } }

    // Virtual methods to be overridden in derived classes
    public abstract double GetDistance();  // km for running, swimming laps, or calculated for cycling
    public abstract double GetSpeed();     // kph or mph
    public abstract double GetPace();      // min per km or mile

    // Method to get the summary of the activity
    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} Activity ({_duration} min): " +
               $"Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}

// Derived Running Class
public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() { return _distance; }
    public override double GetSpeed() { return (_distance / Duration) * 60; }
    public override double GetPace() { return Duration / _distance; }
}

// Derived Cycling Class
public class Cycling : Activity
{
    private double _speed; // Speed in kilometers per hour

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed() { return _speed; }
    public override double GetDistance() { return (_speed * Duration) / 60; }
    public override double GetPace() { return 60 / _speed; }
}

// Derived Swimming Class
public class Swimming : Activity
{
    private int _laps; // Number of laps

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() { return (_laps * 50) / 1000.0; } // Convert meters to kilometers
    public override double GetSpeed() { return (GetDistance() / Duration) * 60; }
    public override double GetPace() { return Duration / GetDistance(); }
}

// Main program to test functionality
public class Program
{
    public static void Main()
    {
        // Create instances of each activity
        Activity run = new Running(new DateTime(2022, 11, 3), 30, 4.8); // Running 4.8 km
        Activity cycle = new Cycling(new DateTime(2022, 11, 4), 40, 20); // Cycling at 20 kph
        Activity swim = new Swimming(new DateTime(2022, 11, 5), 25, 20); // Swimming 20 laps

        // Add activities to a list
        List<Activity> activities = new List<Activity> { run, cycle, swim };

        // Display the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
