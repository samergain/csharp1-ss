using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 FizzBuzzis a group word game for children to teach them about division. Players take turns
to count incrementally, replacing any number divisible by three with the word /fizz/, any
number divisible by five with the word /buzz/, and any number divisible by both with /
fizzbuzz/.
Create a console application in Chapter03 named Exercise03 that outputs a simulated
FizzBuzz game counting up to 100. The output should look something like the following
screenshot:

*/
namespace FlowAndTypeControl
{
    internal class FizzBuzz
    {
        public void FizzBuzz100()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} is a FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} is a Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine($"{i} is a Buzz");
                }
                
            }
        }
    }
}
