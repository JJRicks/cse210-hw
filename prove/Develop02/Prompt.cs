using System;
using System.ComponentModel;

class Prompt {
    public List<string> promptsList = new List<string>();
    public Random random = new Random();

    public Prompt(){ 
        promptsList.Add("What is something you're grateful for today?");
        promptsList.Add("Describe a memorable moment from your day.");
        promptsList.Add("What is a goal you have for this week?");
        promptsList.Add("Reflect on a recent accomplishment and how it made you feel.");
        promptsList.Add("What is something new you learned today?");
        promptsList.Add("Describe a challenge you faced today and how you dealt with it.");
        promptsList.Add("What is a book or article you recently read and what did you learn from it?");
        promptsList.Add("How do you relax and unwind after a busy day?");
        promptsList.Add("What is a hobby you enjoy and why?");
        promptsList.Add("Reflect on your current mood and why you feel that way.");
        promptsList.Add("What is a piece of advice you received recently that resonated with you?");
        promptsList.Add("Describe a person who inspires you and why.");
        promptsList.Add("What is something you want to improve about yourself?");
        promptsList.Add("Reflect on a time when you helped someone and how it made you feel.");
        promptsList.Add("What is something you are looking forward to?");
        promptsList.Add("Describe a place you would like to visit and why.");
        promptsList.Add("What is a habit you want to develop and how do you plan to do it?");
        promptsList.Add("Reflect on a recent dream you had.");
        promptsList.Add("What are three things that made you smile today?");
        promptsList.Add("Describe a recent act of kindness you witnessed or performed.");
        promptsList.Add("What is something that challenges your perspective?");
        promptsList.Add("Reflect on your current relationships and how you can nurture them.");
        promptsList.Add("What is a favorite memory from your childhood?");
        promptsList.Add("Describe a goal you achieved and how you did it.");
        promptsList.Add("What are your aspirations for the next year?");
    }

    public string GetPrompt() {
        int listLen = promptsList.Count;
        int selectedPrompt = random.Next(listLen - 1);
        return promptsList[selectedPrompt];
    }
}