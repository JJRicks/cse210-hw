using System.ComponentModel;
using System.Dynamic;
using Newtonsoft.Json;

public class ChecklistGoal : Goal {
    private bool completionStatus;
    private int timesToComplete;
    private int bonusPointsAmount;
    private int timesCompleted;

    [JsonProperty]
    public bool CompletionStatus {
        get => completionStatus;
        set => completionStatus = value;
    }

    [JsonProperty]
    public int TimesToComplete {
        get => timesToComplete;
        set => timesToComplete = value;
    }
    
    [JsonProperty]
    public int BonusPointsAmount {
        get => bonusPointsAmount;
        set => bonusPointsAmount = value;
    }

    [JsonProperty]
    public int TimesCompleted {
        get => timesCompleted;
        set => timesCompleted = value;
    }
    
    public ChecklistGoal() : base() {
    }

    public override void AccomplishGoal()
    {
        timesCompleted++;
        if(timesCompleted < timesToComplete) {
            CurrentTotalPoints += GoalPoints;
            Console.WriteLine($"Congratulations, you have earned {GoalPoints} points!");
            
        } else {
            CompletionStatus = true;
            CurrentTotalPoints += GoalPoints;
            CurrentTotalPoints += BonusPointsAmount;
            Console.WriteLine($"Congratulations, you have earned {GoalPoints + BonusPointsAmount} points!");

        }
        
        
        
        
    }

    public override string ToString()
    {
        
        string completedX = completionStatus ? "X" : " ";  // shorthand that means the same as below
        // string completedX = " ";
        // if (CompletionStatus == true) {
        //     completedX = "X";
        // }

        return $"[{completedX}] {GoalName} ({GoalDescription}) -- Currently completed: {timesCompleted}/{timesToComplete}";
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