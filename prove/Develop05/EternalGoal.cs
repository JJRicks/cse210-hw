using System.ComponentModel;
using Newtonsoft.Json;

public class EternalGoal : Goal {
    private bool completionStatus;

    [JsonProperty]
    public bool CompletionStatus {
        get => completionStatus;
        set => completionStatus = value;
    }

    public EternalGoal() : base() {
    }

    public override void AccomplishGoal()
    {
        // CompletionStatus = true; // eternal goal cannot be completed
        CurrentTotalPoints += GoalPoints;
        Console.WriteLine($"Congratulations, you have earned {GoalPoints} points!");
        
    }

    public override string ToString()
    {
        string completedX = " ";
        return $"[{completedX}] {GoalName} ({GoalDescription})";
    }

    public override bool IsUnavailable()
    {
        if(CompletionStatus == true) { // completion status can't be true, but whatever lol
            return false;
        } else {
            return false;
        }
    }

}