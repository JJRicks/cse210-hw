using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity {
    
    private string[] prompts = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

    private string[] questions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectingActivity() {
        activityName = "Reflecing Activity";
    }

    public void doSession() {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity. \n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");

        setSessionLength();

        int numRepeats = sessionLength / 10;
        int holdTime = sessionLength % 10;

        Console.Clear();
        Console.WriteLine("Get ready...");
        showSpinner(4);

        Console.WriteLine("\nConsider the following prompt: ");
        Random random = new Random();
        int promptSelection = random.Next(3);
        int questionSelection = 0;

        Console.WriteLine($"\n---- {prompts[promptSelection]} ----\n");
        
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        countdown(5);

        Console.Clear();
        
        for (int i = 0; i < numRepeats; i++){
            questionSelection = random.Next(8);
            Console.Write($"> {questions[questionSelection]} ");
            showSpinner(10);
            Console.Write("\n");
        }
        
    
        finishActivity(holdTime);




    }
}