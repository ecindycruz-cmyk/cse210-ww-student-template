using System;

public class Resume
{
    public string _name;

    //Create the member 
    //variable for the list of Jobs. (Hint: the data type for this should be List<Job> 
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}