using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways
Convert the string to char array, reverse it, then convert it to string again
Print the letters of the string in back direction (from the last to the first) in a for-loop
*/

namespace ArraysAndStrings
{
    public class StringsReverse
    {
        public string ReverseWords1(string word)
        {
            char[] chars = word.ToCharArray();
            string reversed = String.Join(" ", chars);
            return reversed;
        }

        public void ReverseWords2(string word)
        {
            StringBuilder reversed = new StringBuilder();
            for(int i = word.Length - 1; i >= 0; i--)
            {
                reversed.Append(word[i]);
            }
            Console.WriteLine(reversed.ToString());
        }
    }
}
