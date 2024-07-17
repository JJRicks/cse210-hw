public class Cycling : Activity
{
    public double Speed { get; private set; } // Speed in kilometers per hour

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed / 60) * DurationInMinutes;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"{Date} Cycling ({DurationInMinutes} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
