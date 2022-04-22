using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
3. Write a method that calculates all prime numbers in given range and returns them as array
of integers
static int[] FindPrimesInRange(startNum, endNum)
{
}
*/

namespace ArraysAndStrings
{
    public class PrimeNums
    {
        public int[] FindPrimesInRange(int startNum,int endNum)
        {
            int[] result = new int[endNum - startNum];
            int resultIndex = 0;
            for(int i=startNum; i<= endNum; i++)
            {
                int currentNum = i;
                int count = 0;
                for (int j = 1; j <= currentNum; j++)
                {
                    if (currentNum % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("{0} is a Prime Number", currentNum);
                    result[resultIndex] = currentNum;
                    resultIndex++;
                }
            }
            return result;
        }
    }
}
