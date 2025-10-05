public class MeditationActivity : Activity
{
    public MeditationActivity() : base("Meditation", "This activity will help you focus and relax.") { }

    protected override void PerformActivity(int duration)
    {
        Console.WriteLine("Close your eyes and breathe deeply...");
        int timeRemaining = duration;
        while (timeRemaining > 0)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            timeRemaining--;
        }
    }
}