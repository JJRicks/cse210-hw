using System.ComponentModel;
using Newtonsoft.Json;

public class SimpleGoal : Goal {
    private bool completionStatus;

    [JsonProperty]
    public bool CompletionStatus {
        get => completionStatus;
        set => completionStatus = value;
    }

    public SimpleGoal() : base() {
    }

    public override void AccomplishGoal()
    {
        CompletionStatus = true;
        CurrentTotalPoints += GoalPoints;
        Console.WriteLine($"Congratulations, you have earned {GoalPoints} points!");
        
    }

    public override string ToString()
    {
        
        string completedX = completionStatus ? "X" : " ";  // shorthand that means the same as below
        // string completedX = " ";
        // if (CompletionStatus == true) {
        //     completedX = "X";
        // }

        return $"[{completedX}] {GoalName} ({GoalDescription})";
    }

    public override bool IsUnavailable()
    {
        if(CompletionStatus == true) {
            return true;
        } else {
            return false;
        }
    }

}