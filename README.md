# WeekPlanner
This is my week planner application. 

Upon launching the application, you will be asked to "add" or "view". Below I will break down these two options.

Add: By typing "add", you will be able to add agenda items to a specific day. For example, you want to add "Do some code" to mondays agenda. 
You type "add", this then prompts you to identify which day you want to add to. Following our example, you would type "monday". 
After thatm you are asked what you would like to add. Following our example, you would type "Do some code". This then adds "Do some code" to the agenda for monday.

View: By typing "view", you will be able to see the agenda for a specific day. Lets say you were unsure what you ahd planned for Wednesday and wanted to check.
You will be prompted to enter whichever day you would like to check, for our example we would type "wednesday". 
This then displays the agenda for wednesday in green. 

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

How it works:
Each day has its own List<string> which is used to collect agenda items. When you indicate you want to add to monday, the agenda item is added the monday List<string>. 
When you view the agenda for wednesday, we call a DisplayAgenda method which shows each item in the list for the day you specified. 

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


This program has a save and load feature. To save the data, it converts each List<string> into a string[] and then Joins the string[] to make a string. This totals to 7 seperate strings (1 for each day of the week).
The 7 strings are then combined together to make 1 string, which is then written to an AgendItems.txt file. 
To load data, it reads the AgendaItems.txt file and asigns it content to a stirng. The string is then Split into 7 (removing ',') and is assigned to agendaItems array.
Each value in the array is assigned to the corresponding List<string>(e.g. List<string> mondayAgenda will be assigned agendaItems[0]).