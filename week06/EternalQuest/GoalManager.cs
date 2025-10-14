using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Manager!");
        //Load save goals
        LoadGoals();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\n***Your current Score is: {_score}***\n");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        if (_goals.Count == 0)
        {
             Console.WriteLine("No goals have been created yet.");
        return;
        }
    
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine();
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nSelect goal type.");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist Goal");

        if (!int.TryParse(Console.ReadLine(), out int option))
        {
            Console.WriteLine("Invalid option. Please enter a number.");
            return;
        }

        switch (option)
        {
            case 1:
            CreateSimpleGoal();
            break;
            case 2:
            CreateEternalGoal();
            break;
            case 3:
            CreateChecklistGoal();
            break;
            
            default:
            Console.WriteLine("Invalid option");
            break;
        }
    }
    private void GetBaseGoalDetails(out string name, out string description, out int points)
    {
        Console.Write("Enter goal name: ");
        name = Console.ReadLine();
        Console.Write("Enter goal description: ");

        description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        if (!int.TryParse(Console.ReadLine(), out points))
        {
            points = 0;
            Console.WriteLine("Invalid points value, set to 0."); 
        }   
    }
    

       private void CreateSimpleGoal()
    {
        GetBaseGoalDetails(out string name, out string description, out int points);
        _goals.Add(new SimpleGoal(name, description, points));
        Console.WriteLine("Simple goal created.");
    }

    private void CreateEternalGoal()
    {
        GetBaseGoalDetails(out string name, out string description, out int points);
        
        _goals.Add(new EternalGoal(name, description, points));
        Console.WriteLine("Eternal goal created.");
    }

    private void CreateChecklistGoal()
    {
        GetBaseGoalDetails(out string name, out string description, out int points);
        
        Console.Write("Enter target amount: ");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            target = 1;
            Console.WriteLine("Invalid target value, set to 1.");
        }

        Console.Write("Enter bonus points: ");
        if (!int.TryParse(Console.ReadLine(), out int bonus))
        {
            bonus = 0;
            Console.WriteLine("Invalid bonus value, set to 0.");
        }

        _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        Console.WriteLine("Checklist goal created.");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record events for.");
            return;
        }

        Console.WriteLine("\nSelect goal to record an event for:");
        ListGoalDetails();

        Console.Write("Enter the number of the goal: ");
        if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > _goals.Count)
        {
            Console.WriteLine("Invalid option.");
            return;
        }

        int index = option - 1;
        
        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
        
        DisplayPlayerInfo();
    }

    public void SaveGoals()
    {
        string filename = "goals.txt";
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"\nGoals saved successfully to {filename}.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        string filename = "goals.txt";
        if (!File.Exists(filename))
        {
            Console.WriteLine($"\nFile {filename} not found. Starting with score 0 and no goals.\n");
            return;
        }

        try
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
            
                if (int.TryParse(reader.ReadLine(), out int loadedScore))
                {
                    _score = loadedScore;
                }
                else
                {
                    _score = 0;
                }

                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length < 4) continue;

                    
                    string name = parts[1];
                    string description = parts[2];
                    int points = Convert.ToInt32(parts[3]);

                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            
                            bool isComplete = Convert.ToBoolean(parts[4]);
                            _goals.Add(new SimpleGoal(name, description, points, isComplete));
                            break;
                        case "EternalGoal":
                            
                            int amountCompleted = Convert.ToInt32(parts[4]);
                            _goals.Add(new EternalGoal(name, description, points, amountCompleted));
                            break;
                        case "ChecklistGoal":
                            
                            //int chkAmountCompleted = Convert.ToInt32(parts[4]);
                            int target = Convert.ToInt32(parts[5]);
                            int bonus = Convert.ToInt32(parts[6]);
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                            break;
                    }
                }
            }
            Console.WriteLine($"\nGoals loaded successfully from {filename}.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn error occurred while loading goals. Data may be reset: {ex.Message}\n");
            _goals.Clear();
            _score = 0;
        }
    }
}