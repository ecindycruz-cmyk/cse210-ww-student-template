public abstract class Activity
{
    //properties of the activity
    public string Name { get; set; }
    public string Description { get; set; }


    //Constructor of the activity
    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    //Method to start the activity
    public void Start()
    {
        Console.Clear();

        //Show the name and the description of the activity
        Console.WriteLine(Name);
        Console.WriteLine(Description);

        //Ask the user to enter the duration of the activity
        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to start...");
        Thread.Sleep(3000);

        //call the abstract method to perform the activity
        PerformActivity(duration);
        Console.WriteLine("Well done! You have completed the activity");
        Thread.Sleep(2000);

        //Show a message with the duaration of the activity
        Console.WriteLine($"Activity completed: {Name}- Duration: {duration} seconds");
        Thread.Sleep(3000);
    }

    protected abstract void PerformActivity(int duration);
}