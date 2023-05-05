using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekPlanner;

namespace PlannerApplication
{
    internal class Update
    {
        private string? userInput = null;
        private string? agendaItem = null;
        private Days dayEnum;


        //Asks user for input to specify which day they whish to add to and what they want to add
        public void AddToAgenda()
        {
            userInput = null;
           ColoredConsole.WriteLineColored("Which day do you want to add to?", ConsoleColor.Blue);
            ColoredConsole.ChangeTypingColor(ConsoleColor.White); userInput = Console.ReadLine();
            dayEnum = SwitchThroughDays(userInput);

            if (dayEnum != Days.Invalid)
                ColoredConsole.WriteLineColored("Enter new agenda item", ConsoleColor.Blue);
            ColoredConsole.ChangeTypingColor(ConsoleColor.White); agendaItem = Console.ReadLine();
            AddingToAgendaList(agendaItem);

        }

        //This cycles through userInput and assings an enum based upon the input
        private Days SwitchThroughDays(string input)
        {
            switch (input.ToLower())
            {
                case "monday": return Days.Monday;
                case "tuesday": return Days.Tuesday;
                case "wednesday": return Days.Wednesday;
                case "thursday": return Days.Thursday;
                case "friday": return Days.Friday;
                case "saturday": return Days.Saturday;
                case "sunday": return Days.Sunday;
                default: ColoredConsole.WriteLineColored("I'm sorry, I do not understand " + userInput, ConsoleColor.Red); return Days.Invalid; ;
            }

        }

        //This adds the agenda item written by the user to the assigned enum from the above method
        private void AddingToAgendaList(string agenda)
        {
            switch (dayEnum)
            {
                case Days.Monday: Monday.mondayAgenda.Add(agenda); break;
                case Days.Tuesday: Tuesday.tuesdayAgenda.Add(agenda); break;
                case Days.Wednesday: Wednesday.wednesdayAgenda.Add(agenda); break;
                case Days.Thursday: Thursday.thursdayAgenda.Add(agenda); break;
                case Days.Friday: Friday.fridayAgenda.Add(agenda); break;
                case Days.Saturday: Saturday.saturdayAgenda.Add(agenda); break;
                case Days.Sunday: Sunday.sundayAgenda.Add(agenda); break;
            }

        }

        private enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Invalid }
    }
}
