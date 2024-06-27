using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Security;
using Newtonsoft.Json;

public abstract class Goal {
    
    private string goalType;
    private string goalName;
    private string goalDescription;
    private int goalPoints;
    private int currentTotalPoints;

    public string GoalType { 
        get => goalType;   // using shorthand here
        set => goalType = value;
    }
    
    public string GoalName {
        get => goalName; 
        set => goalName = value; 
    }

    public string GoalDescription { 
        get => goalDescription; 
        set => goalDescription = value; 
    }
   
    public int GoalPoints { 
        get => goalPoints; 
        set => goalPoints = value; 
    }

    public int CurrentTotalPoints {
        get => currentTotalPoints;
        set => currentTotalPoints = value;
    }

    protected Goal() {
        goalType = this.GetType().Name;  // get the goal type from the class itself instead of hardcoding it
    }

    public abstract void AccomplishGoal();
    public abstract bool IsUnavailable();

    
}