using System;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Diagnostics.Tracing;
using System.IO.Enumeration;
using System.Security.AccessControl;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        int pointsCount = 0;
        string userMenuChoice = "";
        string filePath = "goals.json";
        List<Goal> goalsList = new List<Goal>();

        while (true) {
            pointsCount = 0;
            foreach(Goal goal in goalsList) {
                pointsCount += goal.CurrentTotalPoints;
            }
            Console.WriteLine($"\nYou have {pointsCount} points\n");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            userMenuChoice = Console.ReadLine();
            string goalType = "";

            switch(userMenuChoice) {
                case "1":
                    
                    Console.WriteLine("The types of goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("4. Bad habit tracking");
                    
                    Console.Write("Which type of goal would you like to create? ");
                    goalType = Console.ReadLine();

                    if (goalType == "1") {
                        SimpleGoal simpleGoal = new SimpleGoal();
                        
                        Console.Write("What is the name of your goal? ");
                        simpleGoal.GoalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        simpleGoal.GoalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        simpleGoal.GoalPoints = int.Parse(Console.ReadLine());
                        simpleGoal.CompletionStatus = false;

                        goalsList.Add(simpleGoal);

                    } else if (goalType == "2") {
                        EternalGoal eternalGoal = new EternalGoal();
                        
                        Console.Write("What is the name of your goal? ");
                        eternalGoal.GoalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        eternalGoal.GoalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        eternalGoal.GoalPoints = int.Parse(Console.ReadLine());
                        eternalGoal.CompletionStatus = false;

                        goalsList.Add(eternalGoal);

                    } else if (goalType == "3") {
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        
                        Console.Write("What is the name of your goal? ");
                        checklistGoal.GoalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        checklistGoal.GoalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        checklistGoal.GoalPoints = int.Parse(Console.ReadLine());
                        
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        checklistGoal.TimesToComplete = int.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        checklistGoal.BonusPointsAmount = int.Parse(Console.ReadLine());
                        
                        checklistGoal.TimesCompleted = 0;
                        checklistGoal.CompletionStatus = false;

                        goalsList.Add(checklistGoal);


                    } else if (goalType == "4") {
                        BadHabitAntigoal badHabit = new BadHabitAntigoal();
                        
                        Console.Write("What is the name of your bad habit? (ex. scroll my phone) ");
                        badHabit.GoalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        badHabit.GoalDescription = Console.ReadLine();
                        Console.Write("How many points should be lost when you do it? ");
                        badHabit.GoalPoints = int.Parse(Console.ReadLine());
                        badHabit.CompletionStatus = false;

                        goalsList.Add(badHabit);

                    } else {
                        Console.WriteLine("Invalid selection, please try again.");
                    }
                    

                    break;
                case "2":
                    Console.WriteLine("The goals are");
                    int i = 1;
                    foreach (Goal goal in goalsList) {
                        Console.WriteLine($"{i}. {goal.ToString()}");
                        i++;
                    }
                    break;
                case "3":
                    string json = JsonConvert.SerializeObject(goalsList, Formatting.Indented, new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    });
                    File.WriteAllText(filePath, json);
                    Console.WriteLine("Goals saved");
                    break;
                case "4":
                    if (File.Exists(filePath)) {
                        string fileContents = File.ReadAllText(filePath);
                        goalsList = JsonConvert.DeserializeObject<List<Goal>>(fileContents, new JsonSerializerSettings {
                            TypeNameHandling = TypeNameHandling.Auto
                        });
                        Console.WriteLine("Goals loaded.");
                    }
                    break;
                case "5":
                    Console.Write("Which goal did you accomplish? ");
                    int goalAccomplished = int.Parse(Console.ReadLine());
                    if(goalsList[goalAccomplished - 1].IsUnavailable()){
                        Console.WriteLine("Whoops! You already completed that goal! ");
                    } else {
                        goalsList[goalAccomplished - 1].AccomplishGoal();
                    }
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid entry, please try again");
                    break;

            }

        }
        

    }
}