// NegativeGoal.cs

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, -points) { }

    public override void RecordEvent() { }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
        return $"{Name} - {Description} (Negative Goal)";
    }
}
