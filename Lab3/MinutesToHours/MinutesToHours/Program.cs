using System;

namespace MinutesToHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutetime;
            int hours;
            int minutesminushours;

            Console.WriteLine("Enter the amount of time in minutes only.");
            minutetime = int.Parse(Console.ReadLine());
            hours = minutetime / 60;
            minutesminushours = minutetime % 60;
            Console.WriteLine("The amount of time in hours and minutes is " + hours + " hours and " + minutesminushours + " minutes.");
        }
    }
}
