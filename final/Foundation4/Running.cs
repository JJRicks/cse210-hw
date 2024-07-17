public class Running : Activity
{
    public double Distance { get; private set; } // Distance in kilometers

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / DurationInMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date} Running ({DurationInMinutes} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
