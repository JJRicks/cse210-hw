public abstract class Activity {

    protected int sessionLength = 0;
    protected string activityName = "";
    protected string activityDescription = "";

    public Activity() {

    }

    public void setSessionLength() {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? (min length 10) ");
        int seconds = int.Parse(Console.ReadLine());
        if (seconds < 10) {
            throw new ArgumentException("Minimum session length must be 10 seconds.");
        }

        sessionLength = seconds;
    }

    public void finishActivity(int holdTime) {
        Console.WriteLine("\n\nWell done!");
        showSpinner(holdTime + 1);

        Console.WriteLine($"\nYou have completed another {sessionLength} seconds of the {activityName}.");
        showSpinner(4);
    }

    public void countdown(int seconds) {
        for(int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i >= 10) {
                Console.Write("\b \b\b \b");
            } else { 
                Console.Write("\b \b");
            }
        }
    }

    public void showSpinner(int seconds) {
        for (int i = -1; i < seconds; i++) {
            Console.Write("|");
            
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(250);
            Console.Write("\b \b");
        
        }
    }
}