using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "software Engineer";
        job1._company = "havard";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job2._jobTitle = "Librarian";
        job2._company = "Makerere University";
        job1._startYear = 2020;
        job1._endYear = 2026;
       
        // job1.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Nankya Sandra";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.DisplayResume();
    }
}