public class ReceptionEvent : Event
{
    public string EmailForRSVP { get; private set; }

    public ReceptionEvent(string title, string description, DateTime date, string time, Address location, string emailForRSVP)
        : base(title, description, date, time, location)
    {
        EmailForRSVP = emailForRSVP;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP at: {EmailForRSVP}";
    }
}