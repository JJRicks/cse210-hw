public class OutdoorGatheringEvent : Event
{
    public string Weather { get; private set; }

    public OutdoorGatheringEvent(string title, string description, DateTime date, string time, Address location, string weather)
        : base(title, description, date, time, location)
    {
        Weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {Weather}";
    }
}
