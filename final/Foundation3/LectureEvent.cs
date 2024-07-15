public class LectureEvent : Event
{
    public string Speaker { get; private set; }
    public int Capacity { get; private set; }

    public LectureEvent(string title, string description, DateTime date, string time, Address location, string speaker, int capacity)
        : base(title, description, date, time, location)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}