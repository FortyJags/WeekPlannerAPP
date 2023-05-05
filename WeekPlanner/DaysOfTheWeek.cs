using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekPlanner;

namespace PlannerApplication
{
    //Each day is a seperate class with a public list which contains agenda items and a DisplayAgenda method which loops through the agenda list and displays each item to the console window.


    internal static class Monday
    {
        public static List<string> mondayAgenda = new List<string>();


        public static void DisplayAgenda()
        {
            foreach (var agenda in mondayAgenda)
            {
                ColoredConsole.WriteLineColored(agenda.ToString(), ConsoleColor.Green);
            }
        }
    }

    internal static class Tuesday
    {
        public static List<string> tuesdayAgenda = new List<string>();

        public static void DisplayAgenda()
        {
            foreach (var agenda in tuesdayAgenda)
            {
                ColoredConsole.WriteLineColored(agenda.ToString(), ConsoleColor.Green);
            }
        }
    }
    internal static class Wednesday
    {
        public static List<string> wednesdayAgenda = new List<string>();



        public static void DisplayAgenda()
        {
            foreach (var agenda in wednesdayAgenda)
            {
                ColoredConsole.WriteLineColored(agenda.ToString(), ConsoleColor.Green);
            }
        }

    }

    internal static class Thursday
    {
        public static List<string> thursdayAgenda = new List<string>();


        public static void DisplayAgenda()
        {
            foreach (var agenda in thursdayAgenda)
            {
                ColoredConsole.WriteLineColored(agenda.ToString(), ConsoleColor.Green);
            }
        }
    }

    internal static class Friday
    {
        public static List<string> fridayAgenda = new List<string>();


        public static void DisplayAgenda()
        {
            foreach (var agenda in fridayAgenda)
            {
                ColoredConsole.WriteLineColored(agenda.ToString(), ConsoleColor.Green);
            }
        }
    }

    internal static class Saturday
    {
        public static List<string> saturdayAgenda = new List<string>();
        public static void DisplayAgenda()
        {
            foreach (var agenda in saturdayAgenda)
            {
                ColoredConsole.WriteLineColored(agenda.ToString(), ConsoleColor.Green);
            }
        }


    }

    internal static class Sunday
    {
        public static List<string> sundayAgenda = new List<string>();

        public static void DisplayAgenda()
        {
            foreach (var agenda in sundayAgenda)
            {
                ColoredConsole.WriteLineColored(agenda.ToString(), ConsoleColor.Green);
            }
        }
    }



}
