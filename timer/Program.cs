using System.Timers;
using System;

public class Example
{
    //public static int secondsCount = 0;
    private static System.Timers.Timer aTimer;
    public static void Main()
    {
        Console.WriteLine("\nPress the Enter key to exit the application...\n");
        WorkTime();
        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();
        Console.WriteLine("Terminating the application...");
    }

    private static void WorkTime()
    {
        // Create a timer that will last for 25 minutes (in miliseconds).
        aTimer = new System.Timers.Timer(1500000); // 25 mins Work time
        Console.WriteLine("Work time starts {0:HH:mm:ss.fff} and will last for 25 minutes", DateTime.Now);
        // Hook up the Elapsed event for the work timer. 
        aTimer.Elapsed += OnTimedEventWork;
        aTimer.AutoReset = false;
        aTimer.Enabled = true;
    }

    private static void RestTime()
    {
        // Create a timer that will last for 5 minutes (in miliseconds).
        aTimer = new System.Timers.Timer(300000);//5 mins
        Console.WriteLine("Rest time starts {0:HH:mm:ss.fff} and will last for 5 minutes", DateTime.Now);
        // Hook up the Elapsed event for the rest timer. 
        aTimer.Elapsed += OnTimedEventRest;
        aTimer.AutoReset = false;
        aTimer.Enabled = true;
    }

    private static void OnTimedEventWork(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine(" \n");
        Console.WriteLine(" \n");
        RestTime();
    }

    private static void OnTimedEventRest(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine(" \n");
        Console.WriteLine(" \n");
        WorkTime();
    }
}
