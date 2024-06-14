using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity {

    public BreathingActivity() {
        activityName = "Breathing Activity";
    }


    public void doSession() {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        setSessionLength();

        Console.Clear();
        Console.WriteLine("Get ready...");
        showSpinner(3);

        int numRepeats = sessionLength / 10;
        int holdTime = sessionLength % 10;

        for (int i = numRepeats; i > 0; i--) {
            Console.Write("\nBreathe in... ");
            countdown(4);
            Console.Write("\nNow breathe out... ");
            countdown(6);
        }

        finishActivity(holdTime);
    }
    
}