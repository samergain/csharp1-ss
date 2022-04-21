// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello There!");

/* Enter favorite color, astrology sign, and street address number to get your hackername
might be something like "Your hacker name is RedGemini480."*/

string color, sign, streetNo;
Console.WriteLine("What's your favorite color?");
color = Console.ReadLine();
Console.WriteLine("What's your astrology sign?");
sign = Console.ReadLine();
Console.WriteLine("What's your street address number?");
streetNo = Console.ReadLine();
Console.WriteLine($"Your hacker name is: {color+sign+streetNo}");


