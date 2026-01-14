using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        resume._name = "John Doe";

        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Tech Corp";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "Innovatech";
        job2._startYear = 2021;
        job2._endYear = 2024;

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}