using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApplication
{
    internal class Menu
    {
        private string? userInput = null;
        private readonly Update update;
        private bool isInMenu;

        public Menu(Update update) { this.update = update; isInMenu = true; }
        public bool IsInMenu { get { return isInMenu; } }

        //Basic menu, takes an input from the user and switches through 2 options. Default there as a fallback.
        public void SwitchMenu()
        {
            userInput = null;
            Console.WriteLine("Would you like to add or view?");
            userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "add": update.AddToAgenda(); break;
                case "view": ViewAgenda(); break;
                case "quit": isInMenu = false; break;
                default: Console.WriteLine("That is not an option"); break;
            }
        }

        //Takes an input and switches through cases. Once a case matches, it then calls on the day class specified (e.g. "monday" would call Monday) and calls the "DisplayAgenda" Method.
        private void ViewAgenda()
        {
            userInput = null;
            Console.WriteLine("Enter a day: ");
            userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "monday": Monday.DisplayAgenda(); break;
                case "tuesday": Tuesday.DisplayAgenda(); break;
                case "wednesday": Wednesday.DisplayAgenda(); break;
                case "thursday": Thursday.DisplayAgenda(); break;
                case "friday": Friday.DisplayAgenda(); break;
                case "saturday": Saturday.DisplayAgenda(); break;
                case "sunday": Sunday.DisplayAgenda(); break;
                default: Console.WriteLine("What?"); break;
            }
        }

    }
}
