using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            //Menu
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1.Breathing Activity");
            Console.WriteLine("2.Reflection Activity");
            Console.WriteLine("3.Listing Activity");
            Console.WriteLine("4.Exit");

            Console.Write("Enter your choce please:");
            string choice = Console.ReadLine();



            switch(choice){


                case"1":
                StartActivity(new BreathingActivity("BreathingActivity","Welcome this activity is here to assist you pace your breathing and abd slowly relax you. Be content in your headspace and close your eyes."));
                break;


                case"2":
                StartActivity(new ReflectionActivity("ReflectionActivity","Welcome this activity is here to assist you on reflecting, think deeply and take your time to e thoughtful about your thinking"));
                break;


                case"3":
                StartActivity(new ListingActivity("ListingActivity","Welcome this activity is here to assist you reflect on good things you have expreienced and help you think broadly"));
                break;


                case"4":
                Console.WriteLine("Exiting program");
                return;

                default:
                Console.WriteLine("Invalid pick. Enter a number between 1 and 4.");
                break;

               


                

            }

        }

    }

    static void StartActivity(Activity activity){
        activity.Start();
    }
}