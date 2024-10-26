// Goal.cs

public abstract class Goal
{
    protected string Name;
    protected string Description;
    protected int Points;

    // Public property to access Points in a read-only way
    public int PointsValue => Points;

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}

