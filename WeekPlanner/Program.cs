using Microsoft.VisualBasic;
using PlannerApplication;
using WeekPlanner;

Update update = new Update();
Menu menu = new Menu(update);
Load load = new Load();


//Final touches on save system needed. Need to implement a load feature as well. Then work on aesthetics

if (File.Exists("AgendaItems.txt")) { Console.WriteLine("File exists"); } else { File.Create("AgendaItems.txt"); }
load.LoadData();
Console.WriteLine("Testing pull);
while (menu.IsInMenu == true)
{
    menu.SwitchMenu();
    
}

Save save = new Save(Monday.mondayAgenda, Tuesday.tuesdayAgenda, Wednesday.wednesdayAgenda, Thursday.thursdayAgenda, Friday.fridayAgenda, Saturday.saturdayAgenda, Sunday.sundayAgenda);
save.SavingData();
