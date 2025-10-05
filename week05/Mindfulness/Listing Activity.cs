public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void PerformActivity(int duration)
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Get ready to start...");
        Thread.Sleep(3000);
        Console.WriteLine("Let's go! List as many items as you can.");
        int count = 0;
        int timeRemaining = duration;
        while (timeRemaining > 0)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
            timeRemaining -= 1;
        }
        Console.WriteLine($"You listed {count} items.");
    }
}