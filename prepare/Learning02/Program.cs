using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       Job job2 = new Job();
       Resume resume1 = new Resume();

       job1._company = "Apple";
       job1._jobTitle = "Software Engineer";
       job1._startYear = 2021;
       job1._endYear = 2023;

       job2._company = "Microsoft";
       job2._jobTitle = "Manager";
       job2._startYear = 2023;
       job2._endYear = 2024;

       resume1._name = "George";

       resume1._jobs.Add(job1);
       resume1._jobs.Add(job2);

       resume1.Display();


    }
}