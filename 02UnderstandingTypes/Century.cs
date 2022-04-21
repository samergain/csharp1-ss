using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
Input: 1
Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
microseconds = 3155673600000000000 nanoseconds
*/

namespace _02UnderstandingTypes
{
    public class Century
    {
        public void ConvertCentury(uint centuries)
        {
            try
            {
                checked
                {
                    ushort years = (ushort)(100 * centuries);
                    uint days = 36524 * centuries;
                    uint hours = 876576 * centuries;
                    uint minutes = 52594560 * centuries;
                    ulong seconds = 3155673600 * centuries;
                    ulong milliseconds = (ulong)(3155673600000 * centuries);
                    ulong microseconds = (ulong)(3155673600000000 * centuries);
                    decimal nanoseconds = 3155673600000000000 * centuries;
                    Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
       
            
        }
    }
}
