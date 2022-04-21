/*
 What will happen if this code executes?
int max = 500;
for (byte i = 0; i < max; i++)
{
WriteLine(i);
}
Create a console application and enter the preceding code. Run the console application
and view the output. What happens?
What code could you add (don’t change any of the preceding code) to warn us about the
problem?

ANSWER:
the loop runs infinitely because i is always less than 500 (byte is 0 to 255). when i is 255 and we add 1 to it, it goes back to 0
the OverFlow exception is not catched by default. we need to wrap the code in a "checked" block to handle it.
try
{
    checked
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());   
}
*/