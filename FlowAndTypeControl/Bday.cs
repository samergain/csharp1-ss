using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000); .
*/

namespace FlowAndTypeControl
{
    public class Bday
{
        public int CalcAge(DateTime bday)
        {
            int age = 0;
            age = DateTime.Now.Subtract(bday).Days;
            return age;
        }
}
}
