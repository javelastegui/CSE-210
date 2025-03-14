using System;

class Program {
    static void Main(string[] args) {
        QuestManager manager = new QuestManager();
        bool exit = false;

        while (!exit) {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string input = Console.ReadLine();
            Console.WriteLine();
            switch (input) {
                case "1":
                    CreateNewGoal(manager);
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter file name to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    Console.WriteLine("Goals saved.");
                    break;
                case "4":
                    Console.Write("Enter file name to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    Console.WriteLine("Goals loaded.");
                    break;
                case "5":
                    Console.Write("Enter goal number to record event: ");
                    if (int.TryParse(Console.ReadLine(), out int goalNum)) {
                        manager.RecordEvent(goalNum - 1);
                    } else {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choose");
                    break;
            }
            Console.WriteLine($"\nTotal Score: {manager.TotalScore}");
        }
    }

    static void CreateNewGoal(QuestManager manager) {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        if (!int.TryParse(Console.ReadLine(), out int points)) {
            Console.WriteLine("Invalid points value.");
            return;
        }

        switch (choice) {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("What is the amount of points associated with this goal? ");
                if (!int.TryParse(Console.ReadLine(), out int requiredCount)) {
                    Console.WriteLine("Invalid required count.");
                    return;
                }
                Console.Write("What is the bonus for accomplish it that many times? ");
                if (!int.TryParse(Console.ReadLine(), out int bonusPoints)) {
                    Console.WriteLine("Invalid bonus points.");
                    return;
                }
                manager.AddGoal(new ChecklistGoal(name, description, points, requiredCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
}
