using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "programmer";
        job1._company = "sony";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "3D Artist";
        job2._company = "Nintendo";
        job2._startYear = 2021;
        job2._endYear = 2023;



        job1.DisplayJobDetails();
        job2.DisplayJobDetails();


        Resume resume1 = new Resume();
        resume1._personsName = "Amelia Baldwin";
        
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResumeDetails();
        
    }
}