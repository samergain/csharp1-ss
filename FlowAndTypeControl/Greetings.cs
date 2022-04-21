using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night"
It's up to you which times should serve as the starting and ending ranges for each of the
greetings. If you need a refresher on how to get the current time, see DateTime
Formatting. When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach)
*/

namespace FlowAndTypeControl
{
    public class Greetings
{
    public void GreetingsUser()
    {
        int currentHour = Int32.Parse(DateTime.Now.ToString("HH"));
            if (currentHour >= 4 && currentHour <= 11)
            {
                Console.WriteLine("Good Morning...");
            }
            if (currentHour >= 12 && currentHour <= 17)
            {
                Console.WriteLine("Good Afternoon...");
            }
            if (currentHour >= 18 && currentHour <= 21)
            {
                Console.WriteLine("Good Evening...");
            }
            if (currentHour >= 22 && currentHour <= 3)
            {
                Console.WriteLine("Good Night...");
            }
      
    }
}
}
