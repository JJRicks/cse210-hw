public abstract class Activity
{
    public string Date { get; private set; }
    public int DurationInMinutes { get; private set; }

    protected Activity(string date, int duration)
    {
        Date = date;
        DurationInMinutes = duration;
    }

    public abstract double GetDistance(); // Distance in kilometers
    public abstract double GetSpeed(); // Speed in kilometers per hour
    public abstract double GetPace(); // Pace in minutes per kilometer

    public virtual string GetSummary()
    {
        return $"{Date} ({DurationInMinutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}