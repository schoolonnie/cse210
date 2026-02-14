using System.Text.Json;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("+==================================+");
        Console.WriteLine("|    Welcome to the EternalQuest   |");
        Console.WriteLine("|           Goal Manager           |");
        Console.WriteLine("+==================================+");
        Console.WriteLine($"      Points: {_score}");
        Console.WriteLine("+----------------------------------+");
        Console.WriteLine("|     Please select an activity:   |");
        Console.WriteLine("+----------------------------------+");
        Console.WriteLine("| 1. Create New Goal               |");
        Console.WriteLine("| 2. List Goals                    |");
        Console.WriteLine("| 3. Save State (automatic on exit)|");
        Console.WriteLine("| 4. Load State                    |");
        Console.WriteLine("| 5. Record Event                  |");
        Console.WriteLine("| 6. Delete Goal                   |");
        Console.WriteLine("| 7. Exit                          |");
        Console.WriteLine("+==================================+");
    }

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }
    
    public void Start()
    {
        bool isRunning = true;
        while(isRunning)
        {
            string[] choices = ["1","2","3","4","5","6","7"];
            string userChoice;
            while (true)
            {
                DisplayMenu();
                Console.WriteLine("");
                userChoice = Console.ReadLine();
                if (choices.Contains(userChoice))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("+----------------------------------+");
                    Console.WriteLine("| Invalid input. Please            |");
                    Console.WriteLine("| input a number [1-3]             |");
                    Console.WriteLine("+----------------------------------+");
                    Console.WriteLine("");
                }
            }
            switch (userChoice)
            {
                case "1":
                    CreateGoal();
                    break;
                
                case "2":
                    Console.WriteLine("+----------------------------------+");
                    Console.WriteLine(" List of goals:");
                    Console.WriteLine(" (Press ENTER to return)");
                    Console.WriteLine("+----------------------------------+");
                    ListGoalDetails();
                    Console.ReadLine();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    if (System.IO.File.Exists("SaveData.json"))
                    {
                        LoadGoals();
                    }
                    break;
                
                case "5":
                    RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("+----------------------------------+");
                    Console.WriteLine(" List of goals:");
                    Console.WriteLine(" (enter NUMBER to delete)");
                    Console.WriteLine("+----------------------------------+");
                    ListGoalNames();
                    int choiceIndex = int.Parse(Console.ReadLine()) - 1;
                    _goals.RemoveAt(choiceIndex);
                    break;
                    
                case "7":
                    SaveGoals();
                    isRunning = false;
                    break;
                    
            }
            
        }
    }
    public void ListGoalNames()
    {
        int number = 0;
        foreach(var goal in _goals)
        {
            number++;
            Console.WriteLine($"{number}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        int number = 0;
        foreach(var goal in _goals)
        {
            number++;
            Console.WriteLine($"{number}. {goal.GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        string goalChoice;
        while(true)
        {
            Console.WriteLine("+==================================+");
            Console.WriteLine("| 1. Simple Goal                   |");
            Console.WriteLine("| 2. Eternal Goal                  |");
            Console.WriteLine("| 3. Checklist Goal                |");
            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("| Please select a type of goal:    |");
            Console.WriteLine("+==================================+");
            Console.WriteLine("");
            goalChoice = Console.ReadLine();
            string[] choices = ["1","2","3"];

            if (!choices.Contains(goalChoice))
            {
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Invalid input. Please            |");
                Console.WriteLine("| input a number [1-3]             |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
            }
            else
            {
                break;
            }
        }
        

        string goalName;
        string goalDesc;
        int goalPoints;

        switch (goalChoice)
        {
            case "1":
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter a name for          |");
                Console.WriteLine("| your simple goal:                |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalName = Console.ReadLine();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter a brief description |");
                Console.WriteLine($"| for {goalName}:                  |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalDesc = Console.ReadLine();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter the point amount    |");
                Console.WriteLine($"| for {goalName}:                  |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalPoints = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDesc, goalPoints);
                _goals.Add(simpleGoal);
                break;

            case "2":
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter a name for          |");
                Console.WriteLine("| your eternal goal:               |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalName = Console.ReadLine();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter a brief description |");
                Console.WriteLine($"| for {goalName}:                  |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalDesc = Console.ReadLine();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter the point amount    |");
                Console.WriteLine($"| for {goalName}:                  |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalPoints = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(goalName, goalDesc, goalPoints);
                _goals.Add(eternalGoal);
                break;

            case "3":
                int goalTarget;
                int goalBonus;

                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter a name for          |");
                Console.WriteLine("| your checklist goal:             |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalName = Console.ReadLine();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter a brief description |");
                Console.WriteLine($"| for {goalName}:                  |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalDesc = Console.ReadLine();
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter the point amount    |");
                Console.WriteLine($"| for {goalName}:                  |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter the target          |");
                Console.WriteLine("| completion amount for            |");
                Console.WriteLine($" {goalName}:                      ");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalTarget = int.Parse(Console.ReadLine());
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| Please enter the bonus point     |");
                Console.WriteLine($"| amount for {goalName}:           |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("");
                goalBonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, goalTarget, goalBonus);
                _goals.Add(checklistGoal);
                break;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("+==================================+");
        Console.WriteLine("|   Please selece the goal that    |");
        Console.WriteLine("|   you would like to record an    |");
        Console.WriteLine("|            event for.            |");
        Console.WriteLine("+==================================+");
        Console.WriteLine("");
        ListGoalNames();
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (_goals[goalIndex].IsComplete())
        {
            Console.WriteLine("+==================================+");
            Console.WriteLine("|      Goal already completed      |");
            Console.WriteLine("+==================================+");
            Console.WriteLine("");
            Console.ReadLine();
        }
        else
        {
            int pointsToAdd = _goals[goalIndex].RecordEvent();
            _score += pointsToAdd;
        }
    }
    public void SaveGoals()
    {
        string fileName = "SaveData.json";
        var lines = new List<string>();
        
        // save score
        lines.Add(_score.ToString());
        
        // save goal with type of goal
        foreach(Goal goal in _goals)
        {
            string goalType = goal.GetType().Name;
            var options = new JsonSerializerOptions { IncludeFields = true };
            string goalJson = JsonSerializer.Serialize(goal, goal.GetType(), options);
            lines.Add($"{goalType}:{goalJson}");
        }
        
        File.WriteAllLines(fileName, lines);
    }
    public void LoadGoals()
    {
        string fileName = "SaveData.json";
        string[] lines = File.ReadAllLines(fileName);
        
        // first load score
        _score = int.Parse(lines[0]);
        
        // load goals
        _goals.Clear();
        var options = new JsonSerializerOptions { IncludeFields = true };
        
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            int colonIndex = line.IndexOf(':');
            string goalType = line.Substring(0, colonIndex);
            string goalJson = line.Substring(colonIndex + 1);
            
            Goal goal = goalType switch
            {
                "SimpleGoal" => JsonSerializer.Deserialize<SimpleGoal>(goalJson, options),
                "EternalGoal" => JsonSerializer.Deserialize<EternalGoal>(goalJson, options),
                "ChecklistGoal" => JsonSerializer.Deserialize<ChecklistGoal>(goalJson, options),
                _ => null
            };
            
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
    }
}