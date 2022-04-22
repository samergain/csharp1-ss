using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted
*/

namespace ArraysAndStrings
{
    public class StringsPalindrom
    {
        public void findPalindromes(string line)
        {
            string[] words = line.Split(' ');
            string[] palindromes = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i] == words[i].Reverse())
                {
                    palindromes[i] = words[i];
                }
            }
            palindromes = palindromes.Distinct().ToArray();
            //palindromes = palindromes.Sort();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < palindromes.Length; i++)
            {
                output.Append(palindromes[i]+", ");
            }
            Console.WriteLine(output.ToString());

        }
    }
}
