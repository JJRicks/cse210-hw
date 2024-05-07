using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Job {
    public string company;
    public string jobTitle;
    public int startYear;
    public int endYear;

    public Job() {
        // this.company = company;
        // this.jobTitle = jobTitle;
        // this.startYear = startYear;
        // this.endYear = endYear;

    }

    public void Display() {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }


}