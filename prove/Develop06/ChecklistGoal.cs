// ChecklistGoal.cs

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _progress;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _progress = 0;
    }

    public override void RecordEvent()
    {
        _progress++;
    }

    public override bool IsComplete() => _progress >= _target;

    public override string GetStringRepresentation()
    {
        return $"{Name} - {Description} (Checklist Goal) - Progress: {_progress}/{_target}";
    }
}
