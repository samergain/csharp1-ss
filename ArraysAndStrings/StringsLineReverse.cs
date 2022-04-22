using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
All other characters are considered part of words, e.g. C++, a+b, and a77 are
considered valid words.
The sentences always start by word and end by separator.
*/

namespace ArraysAndStrings
{
    public class StringsLineReverse
    {
        public void LineReverse(string inputLine)
        {
            string[] chars = { ".", ",", ":", ";", "=", "(", ")", "&", "[", "]", "\"", "'", "\\", "/", "!", "?", " " };
            string[] lineSeparators = inputLine.Split(chars,0);
            string[] separatorsArray = new string[lineSeparators.Length];
            StringBuilder output = new StringBuilder();

            //still need to figure out the right way to do this part!
            /*
            for(int i=0; i<inputLine.Length; i++)
            {
                if (chars.Contains(inputLine[i]){
                    separatorsArray.Append(inputLine[i]);
                }
            }
            */
            for(int i=0; i<lineSeparators.Length; i++)
            {
                output.Append(lineSeparators[i]+separatorsArray[i]);
            }
            Console.WriteLine(output.ToString());
        }
    }
}
