using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._jobtitles = "Software Engineer";
        job1._CompanyName = "Mircrosoft";
        job1._StartingYear = 2019;
        job1._endYear = 2022;

        Jobs job2 = new Jobs();
        job2._jobtitles = "Manager";
        job2._CompanyName = "Apple";
        job2._StartingYear = 2022;
        job2._endYear = 2025;

        Resumes myResume = new Resumes();
        myResume._names = "Miguel Lozano";

        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume.Display();


    }
}