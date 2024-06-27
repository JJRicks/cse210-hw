using System.ComponentModel;
using Newtonsoft.Json;

public class BadHabitAntigoal : Goal {
    private bool completionStatus;

    [JsonProperty]
    public bool CompletionStatus {
        get => completionStatus;
        set => completionStatus = value;
    }

    public BadHabitAntigoal() : base() {
    }

    public override void AccomplishGoal()
    {
        // CompletionStatus = true; // bad habit cannot be completed
        CurrentTotalPoints -= GoalPoints;
        Console.WriteLine($"Sorry, you have lost {GoalPoints} points!");
        
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