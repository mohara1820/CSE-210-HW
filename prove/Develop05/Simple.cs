public class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override bool Completed()
    {
        return _isComplete;
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }
}
