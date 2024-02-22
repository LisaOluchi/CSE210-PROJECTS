using System;
using System.Collections.Generic;

public class Scheduler{
    private List<Task> tasks;
    private List<Event> events;
    private List<Reminder> reminders;

    public Scheduler(){

        tasks = new List<Task>();
        events = new List<Event>();
        reminders = new List<Reminder>();

    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
        Console.WriteLine("Task added successfully.");
    }

    public void AddEvent(Event @event)
    {
        events.Add(@event);
        Console.WriteLine("Event added successfully.");
    }

    public void SetReminder(){
        Console.WriteLine("Reminder added successfully.");
    }

    public void DisplaySchedule()
    {
        Console.WriteLine("===== Schedule =====");
        Console.WriteLine("Tasks:");
        foreach (var task in tasks)
        {
            task.DisplayDetails();
        }
        Console.WriteLine("Events:");
        foreach (var @event in events)
        {
            @event.DisplayDetails();
        }
        Console.WriteLine();
    }



    
    
}