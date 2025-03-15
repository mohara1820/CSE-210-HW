public class Checklist : Goal
{
    private int _targetPoints;
    private int _currentPoints;

    public Checklist(string name, string description, int points, int targetPoints)
        : base(name, description, points)
    {
        _targetPoints = targetPoints;
        _currentPoints = 0;
    }

    public override bool Completed()
    {
        return _currentPoints >= _targetPoints;
    }

    public int RecordProgress() // ✅ Fixed: Added this method
    {
        _currentPoints++;
        if (_currentPoints >= _targetPoints)
        {
            Console.WriteLine("Checklist goal completed! Bonus awarded.");
            return _points + 500; // Example bonus
        }
        return _points;
    }
}