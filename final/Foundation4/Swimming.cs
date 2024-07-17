public class Swimming : Activity
{
    private const double LapLength = 0.05; // Each lap is 50 meters, 0.05 km
    public int Laps { get; private set; }

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * LapLength;
    }

    public override double GetSpeed()
    {
        return GetDistance() / DurationInMinutes * 60;
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date} Swimming ({DurationInMinutes} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
