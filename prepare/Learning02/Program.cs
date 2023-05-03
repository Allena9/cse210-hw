using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        
        job1._company = "Google";
        job1._jobTitle = "Software engineer";
        job1._startYear = 2018;
        job1._endYear = 2022;

        job2._company = "Apple";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume1 = new Resume();

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1._name = "George Bush";

        resume1.display();

    }
}