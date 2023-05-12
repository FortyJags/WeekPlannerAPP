using PlannerApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekPlanner
{
    internal class Load
    {
        
        private string[] agendaItems = new string[7];
        private string loadedData;
        private List<string> temp = new List<string>();

        //Assigns the text in AgendaItems.txt to loadedData, this is then put through a for loop which splits loadaedData at each comma and assigns each split value to their corresponding place in agendaItems array.
        //agendaItems is then converted to a List to make it easier to assign agenda values to their corresponding day.
        //Fianally, the agendaItems for each day are assigned to their corresponding day and are ready for recall when they are called.
        public void LoadData()
        {

            using (StreamReader reader = new("AgendaItems.txt"))
            {
                 loadedData = reader.ReadToEnd();

                for (int i = 0; i < agendaItems.Length; i++)
                {
                    agendaItems[i] = loadedData.Split(',')[i];
                }
                agendaItems.ToList().ForEach(item => { temp.Add(item); });

                Monday.mondayAgenda.Add(temp[0]);
                Tuesday.tuesdayAgenda.Add(temp[1]);
                Wednesday.wednesdayAgenda.Add(temp[2]);
                Thursday.thursdayAgenda.Add(temp[3]);
                Friday.fridayAgenda.Add(temp[4]);
                Saturday.saturdayAgenda.Add(temp[5]);
                Sunday.sundayAgenda.Add(temp[6]);
            }
        }

    }
}
