using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    //List of the activities
        //I add the meditation activity.
    {
        List<Activity> activities = new List<Activity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity(),
            new MeditationActivity()
        };

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Activity Menu:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i].Name}");
            }
            Console.WriteLine($"{activities.Count + 1}.Exit");

            Console.Write("Enter the number of the activity you want to perform: ");
            int option = int.Parse(Console.ReadLine()) - 1;
            if (option >= 0 && option < activities.Count)
            {
                activities[option].Start();
            }
            else if (option == activities.Count)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}