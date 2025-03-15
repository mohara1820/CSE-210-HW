public class Eternal : Goal
{
    public Eternal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override bool Completed()
    {
        return false; 
    }

    public int RecordProgress()
    {
        return _points; 
    }
}