using System;

class Program
{
    static void Main(string[] args)
    {
        // First Job

        Job johnJob = new Job();
        johnJob._company = "SanIluHpp Business";
        johnJob._jobTitle = "Junior Admin";
        johnJob._startYear = 2022;
        johnJob._endYear = 2023;

        //Second Job

        Job johnJob1 = new Job();
        johnJob1._company = "LDS Church";
        johnJob1._jobTitle = "Executive Assistant";
        johnJob1._startYear = 2020;
        johnJob1._endYear = 2022;


        Resume resume = new Resume();
        resume._name = "John Ntambwe";
        resume.jobs.Add(johnJob);
        resume.jobs.Add(johnJob1);

        resume.Display();
       
    }
}