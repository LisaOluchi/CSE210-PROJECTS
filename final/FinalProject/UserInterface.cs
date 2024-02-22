using System;

public class UserInterface{
    public void DisplayMenu(){

        Console.WriteLine("=====Welcome to the Time Management Schedule Program =====");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Add Event");
        Console.WriteLine("3. Set Reminder");
        Console.WriteLine("4. Display schedule");
        Console.WriteLine("5.Exit Program");
        Console.WriteLine("6. Enter your choice");
    }

    //Get user Input
    public int GetUserInput(){

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice)){
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.Write("Enter your choice: ");
        }

        return choice;

    }

     public Task GetTaskDetails(){

        Console.WriteLine("Please enter your task details:");
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.Write("Due Date (MM/dd/yyyy): ");
        DateTime dueDate;
        while (!DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out dueDate))
        {
            Console.WriteLine("Invalid date format. Please enter date in MM/dd/yyyy format.");
            Console.Write("Due Date (MM/dd/yyyy): ");
        }

        Console.Write("Priority (1 - Low, 2 - Medium, 3 - High): ");
        int priority;
        while (!int.TryParse(Console.ReadLine(), out priority) || priority < 1 || priority > 3){

        Console.WriteLine("Invalid concern.Please enter 1 for Low, 2 for Medium, or 3 for High.");
        Console.Write("Concern(1- Low, 2- Meduim, 3- High):");
        }

        return new Task(name, dueDate,priority);

        

    }


    public Event GetEventDetails(){

        Console.WriteLine("Enter event details:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Location: ");
        string location = Console.ReadLine();
        Console.Write("Start Time (MM/dd/yyyy HH:mm): ");
        DateTime startTime;
        while (!DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out startTime))
        {
            Console.WriteLine("Invalid date/time format. Please enter date/time in MM/dd/yyyy HH:mm format.");
            Console.Write("Start Time (MM/dd/yyyy HH:mm): ");
        }

        Console.Write("End time (MM/dd/yyyy HH:mm)");
        DateTime endTime;
        while(!DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out endTime))
        {
            Console.WriteLine("Invalid date/time format. Please enter date/time in MM/dd/yyyy HH:mm format.");
            Console.Write("End Time (MM/dd/yyyy HH:mm): ");
        }
        return new Event(name, location, startTime, endTime);


    }
}