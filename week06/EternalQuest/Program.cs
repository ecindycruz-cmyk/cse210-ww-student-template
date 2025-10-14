using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
      {
        GoalManager manager = new GoalManager();
        manager.Start();

        while (true)
        {
            manager.DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Select a choice from the menu: ");

            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid option. Please enter a number.");
                continue;
            }

            switch (option)
            {
                case 1:
                    manager.CreateGoal();
                    break;
                case 2:
                    manager.ListGoalDetails();
                    break;
                case 3:
                    manager.RecordEvent();
                    break;
                case 4:
                    manager.SaveGoals();
                    break;
                case 5:
                    manager.LoadGoals();
                    break;
                case 6:
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}