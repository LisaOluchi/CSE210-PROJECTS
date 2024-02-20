using System;
using System.Collections.Generic;

namespace EternalQuestProgram
{
    class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Start()
        {
            Console.WriteLine("Welcome to the Eternal Quest");
            DisplayMenu();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal names");
            Console.WriteLine("3. List Goal info");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Exit");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Player's current score: {_score}");
        }

        public void ListGoalNames()
        {
            Console.WriteLine("List of goal names:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetShortName());
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("List of goal details follow as :");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("Creating a new goal...");

            Console.Write("Please enter the short name of your goal: ");
            string shortName = Console.ReadLine();

            Console.WriteLine("Please enter the description of your goal");
            string description = Console.ReadLine();

            Console.WriteLine("Please enter the number of points for your goal");
            int points;
            while (!int.TryParse(Console.ReadLine(), out points))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // Prompt user to choose goal type
            Console.WriteLine("Choose the type of Goal:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string typeChoice = Console.ReadLine();

            Goal newGoal;
            switch (typeChoice)
            {
                case "1":
                    newGoal = new SimpleGoal(); 
                    break;
                case "2":
                    newGoal = new EternalGoal(); 
                    break;
                case "3":
                    Console.WriteLine("Enter the target number for the checklist goal please:");
                    int target;
                    while (!int.TryParse(Console.ReadLine(), out target))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }

                    Console.WriteLine("Enter the bonus points for completing the checklist goal please:");
                    int bonus;
                    while (!int.TryParse(Console.ReadLine(), out bonus))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                    newGoal = new ChecklistGoal(target, bonus); 
                    break;
                default:
                    Console.WriteLine("Invalid choice, creating a simple goal by default.");
                    newGoal = new SimpleGoal(); 
                    break;
            }

            newGoal.SetShortName(shortName); 
            newGoal.SetDescription(description); 
            newGoal.SetPoints(points); 

            _goals.Add(newGoal);

            Console.WriteLine("Goal successfully created, bye!");
        }
    }
}
