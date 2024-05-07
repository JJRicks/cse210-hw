using System;
using System.Collections.Frozen;
using System.Runtime.Serialization;
using System.Threading.Tasks.Dataflow;

class Program {
    static void Main(string[] args)
    {
        // Person fred = new Person("Fred", "Flinstone");
        // Person steve = new Person("Steve", "Ballmer");

        // fred.EasternStyleName();
        // steve.WesternStyleName();

        Job job1 = new Job();
        job1.jobTitle = "PGV Team Member";
        job1.company = "Intel";
        job1.startYear = 2020;
        job1.endYear = 2021;

        //job1.Display();

        Job job2 = new Job();
        job2.company = "Walmart";
        job2.jobTitle = "Frontend Checkout TA";
        job2.startYear = 2024;
        job2.endYear = 2024;

        //job2.Display();
        
        Resume myResume = new Resume();

        myResume.name = "Joel";
        myResume.jobList.Add(job1);
        myResume.jobList.Add(job2);

        myResume.Display();



    }
}