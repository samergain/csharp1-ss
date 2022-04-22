using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
2. Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear. The syntax should be as follows:
+ some item
- some item
--
Your program should read in the user's input and determine if it begins with a “+” or “-“ or
if it is simply “—“ . In the first two cases, your program should add or remove the string
given ("some item" in the example). If the user enters just “—“ then the program should
clear the current list. Your program can start each iteration through its loop with the
following instruction:
Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
*/

namespace ArraysAndStrings
{
    public class groceryList
    {
        public static void manageList()
        {
            ArrayList list = new ArrayList();
            while (true)
            {
                Console.WriteLine("Options: add to list ( + item ) | remove from list ( - item ) | clear list ( -- ) | exit (xx)");
                string input = Console.ReadLine();
                string operation = input.Substring(0, 2);
                string entry = input.Substring(2);
                Console.WriteLine(operation);
                switch (operation)
                {
                    case ("+ "):
                        list.Add(entry);
                        break;
                    case ("- "):
                        list.Remove(entry);
                        break ;
                    case ("--"):
                        list.Clear();
                        break ;
                    case ("xx"):
                        return;
                      
                    default:
                        Console.WriteLine("Undefined Option!");
                        break ;
                }
                foreach (string item in list)
                {
                    Console.WriteLine (item);
                }
            }
        }
    }
}
