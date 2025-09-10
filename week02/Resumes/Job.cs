using System;

//class Program
//{
//static void Main(string[] args)
//{
//Console.WriteLine("Hello World! This is the Resumes Project.");
//}
//}
//Create a new file for your job class.
// By convention this should be named Job.cs 
public class Job
{
    //Create member variables in the class for each element
    //that this class should contain. 
    //By convention these member variables 
    // should begin with an underscore and a lowercase letter such as _jobTitle .
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public string _nameCompany;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_nameCompany}) {_startYear}-{_endYear}");
    }


}