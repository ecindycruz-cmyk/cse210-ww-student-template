public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void PerformActivity(int duration)
    {
        int timeRemaining = duration;
        while (timeRemaining > 0)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000);
            timeRemaining -= 4;
            if (timeRemaining <= 0) break;
            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000);
            timeRemaining -= 4;
        }
    }
}