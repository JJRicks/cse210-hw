class ListingActivity : Activity {

    private string[] questions = { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    public ListingActivity() {
        activityName = "Listing Activity";
    }


    public void doSession() {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity. \n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        setSessionLength();

        // int numRepeats = sessionLength / 10;
        // int holdTime = sessionLength % 10;
        int numAnswers = 0;

        Console.Clear();
        Console.WriteLine("Get ready...");
        showSpinner(4);

        Random random = new Random();
        int questionSelection = random.Next(5);
        Console.WriteLine("List as many responses as  you can to the following prompt: ");

        Console.WriteLine($"--- {questions[questionSelection]} ---");

        Console.Write("You may begin in: ");
        countdown(5);
        Console.Write("\n");

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(sessionLength);
       
        while (currentTime < endTime) {
            Console.Write("> ");
            Console.ReadLine();
            numAnswers++;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {numAnswers} items!");

        finishActivity(4);
        
    }

}