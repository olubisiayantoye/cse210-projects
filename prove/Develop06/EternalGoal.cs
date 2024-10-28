// EternalGoal.cs

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent() { }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
        return $"{Name} - {Description} (Eternal Goal)";
    }
}
