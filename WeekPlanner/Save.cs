using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApplication
{
    internal class Save
    {

         private string monday, tuesday, wednesday, thursday, friday, saturday, sunday;

        private string? allAgendaItems;
        //Constructor takes the lists as parameters and uses the ConvertingListToString function to convert the list to an array and then to a string.
        public Save(List<string> mondayAgenda, List<string> tuesdayAgenda, List<string> wednesdayAgenda, List<string> thursdayAgenda, List<string> fridayAgenda, List<string> saturdayAgenda, List<string> sundayAgenda)
        {

            monday = ConvertingListToString(mondayAgenda);
            tuesday = ConvertingListToString(tuesdayAgenda);
            wednesday = ConvertingListToString(wednesdayAgenda);
            thursday = ConvertingListToString(thursdayAgenda);
            friday = ConvertingListToString(fridayAgenda);
            saturday = ConvertingListToString(saturdayAgenda);
            sunday = ConvertingListToString(sundayAgenda);

        }





        //takes each string for each day and concats them into one string. This is then written to the file AgendaItems. Commas are used to seperate as this will make loading the information and splitting it much easier.
        public void SavingData()
        {


            allAgendaItems = $"{monday}, {tuesday}, {wednesday}, {thursday}, {friday}, {saturday},{sunday}";

            File.WriteAllText("AgendaItems.txt", allAgendaItems);

        }


        //Takes a lsit as an argument, this converts the list into an array. The array is then converted into a string and returned 
        private string ConvertingListToString(List<string> agenda)
        {

            string[] temp = new string[agenda.Count];
            string ready;
            for (int i = 0; i < agenda.Count; i++)
            {
                temp[i] = agenda[i];
            }

            ready = String.Join(",", temp);
            if (ready == "") { return "No Plans"; }
            else { return ready; }

        }



    }
}
