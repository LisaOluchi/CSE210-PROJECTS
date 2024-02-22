using System;

class Program
{
    static void Main(string[] args)
    {
        Scheduler scheduler = new Scheduler();
        UserInterface ui = new UserInterface();

        //Main loop
        bool running = true;
        while (running)
        {
            //menu and user input
            ui.DisplayMenu();
            int choice = ui.GetUserInput();

            switch (choice)
            {
                case 1:
                    Task newTask = ui.GetTaskDetails();
                    scheduler.AddTask(newTask);
                    break;

                case 2:
                    Event newEvent = ui.GetEventDetails();
                    scheduler.AddEvent(newEvent);
                    break;

                case 3:
                    scheduler.SetReminder();
                    break;

                case 4:
                    scheduler.DisplaySchedule();
                    break;

                case 5:
                    //Exit program
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Leaving Program. Thank you and goodbye!");
    }
}
