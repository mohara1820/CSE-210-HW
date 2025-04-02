public abstract class Event
{
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{title}\n{description}\nDate: {date}, Time: {time}\nLocation:\n{address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"Event Type: {this.GetType().Name}\nTitle: {title}\nDate: {date}";
    }
}
