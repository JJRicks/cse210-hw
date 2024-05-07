using System;
using System.Security;
using System.Collections.Generic;

class Resume {
    public string name;
    public List<Job> jobList = new List<Job>();


    public Resume(){

    }

    public void Display() {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Jobs:");
        foreach(Job job in jobList) {
            job.Display();
        }
    }
}