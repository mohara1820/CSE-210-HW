public class Entry
{
    public string _userPrompt { get; set; }
    public string _dateTime { get; set; }
    public string _userEntry { get; set; }

    public void Display()
    {
        Console.WriteLine($"{_dateTime} - {_userPrompt}\n{_userEntry}\n");
    }
}