using System;

class Program
{
    static void Main(string[] args)

    {
        //Create a new job instance named job1 
        Job job1 = new Job();
        //Set the member variables using the dot notation
        //(for example, job1._jobTitle = "Software Engineer";
        job1._jobTitle = "Software Development";
        job1._nameCompany = "Microsoft";
        job1._startYear = 2023;
        job1._endYear = 2024;

        //Create a second job, set its variables,
        //display this company on the screen as well.
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._nameCompany = "Apple";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Alison Rose";

        //Add the two jobs you created earlier, 
        //to the list of jobs in the resume object
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}