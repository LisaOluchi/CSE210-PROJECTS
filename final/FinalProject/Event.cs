using System;

public class Event{

    //Properties
    public string Name {get; set;}
    public string Location{get; set;}
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }


    public Event(string name, string location, DateTime startTime, DateTime endTime){

        Name = name;
        Location = location;
        StartTime = startTime;
        EndTime = endTime;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Event: {Name}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine($"Start Time: {StartTime}");
        Console.WriteLine($"End Time: {EndTime}");
        Console.WriteLine();
    }

}