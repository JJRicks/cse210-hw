public abstract class Event
{
    public string Title { get; protected set; }
    public string Description { get; protected set; }
    public DateTime Date { get; protected set; }
    public string Time { get; protected set; }
    public Address Location { get; protected set; }

    protected Event(string title, string description, DateTime date, string time, Address location)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Location = location;
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()} Time: {Time}\nLocation: {Location}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"{GetType().Name.Replace("Event", "")}: {Title} on {Date.ToShortDateString()}";
    }
}