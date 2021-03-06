using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
       Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
will print the following pattern: If you find yourself getting stuck, try recreating the two
examples that we just talked about in this chapter first.They’re simpler, and you can
compare your results with the code included above.
This can actually be a pretty challenging problem, so here is a hint to get you going. I used
three total loops.One big one contains two smaller loops.The bigger loop goes from line
to line. The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars.
*
***
*****
*******
*********
*/
namespace FlowAndTypeControl
{
    public class Pyramid
{
       public void PrintPyramid()
        {
            StringBuilder result = new("", 20);
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if ((4 - i) <= j && j <= (4 + i))
                    {
                        result.Append("*");
                    }
                    else
                    {
                        result.Append(' ', 1);
                    }
                }
                Console.WriteLine(result.ToString());
                result.Clear();
            }
       }
}
}
