using System;

public class Reminder{
    //Properties
    public string Message {get; set;}
    public DateTime ReminderTime {get; set;}

    public Reminder(string message, DateTime reminderTime){

        Message = message;
        ReminderTime = reminderTime;
    }

    public void DisplayDetails(){

        Console.WriteLine($"Reminder:{Message}");
        Console.WriteLine($"Reminder Time: {ReminderTime}");
        Console.WriteLine();
    }

}