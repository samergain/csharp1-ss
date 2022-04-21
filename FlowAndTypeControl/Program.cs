/*
 Controlling Flow and Converting Types
Test your Knowledge
1. What happens when you divide an int variable by 0?
we get an unhandled system exception System.DivideByZeroException: 'Attempted to divide by zero.'

2. What happens when you divide a double variable by 0?
returns infinity since double is a floating point value. zero (double) is not exactly zero but a number approaching zero. that's why double/(approaching to zero) = infinity

3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
int arithmetic overflow either throws an OverflowException or discards the most significant bits of the result

4. What is the difference between x = y++; and x = ++y;?
x = y++ executes the statement and then increments the value. x = ++y increments the value and then executes the statement

5. What is the difference between break, continue, and return when used inside a loop
statement?
break will terminate the loop execution and continue with whatever code that comes after the loop
continue will terminate the current iteration and start a new one
return will terminate the execution of the whole function that contains the loop

6. What are the three parts of a for statement and which of them are required?
initializer, condition, iterator
all of them are optional. if none of them is defined, we enter an infinite loop

7. What is the difference between the = and == operators?
= assigns a value 
== compares the reference identity

8. Does the following statement compile? for ( ; true; ) ;
yes, it's an infinite loop

9. What does the underscore _ represent in a switch expression?
it replaces the "default" keyword which executes when none of the switch cases are matched

10. What interface must an object implement to be enumerated over by using the foreach
statement?
IEnumerable 

*/
//=================================================================================================================================
/*
using FlowAndTypeControl;
FizzBuzz fizz = new();
fizz.FizzBuzz100();
*/
//=================================================================================================================================
/*
using FlowAndTypeControl;
Pyramid x = new Pyramid();
x.PrintPyramid();
*/
//=================================================================================================================================
/*
using FlowAndTypeControl;
Bday birth = new Bday();
int age = birth.CalcAge(Convert.ToDateTime("6/20/1983"));
Console.WriteLine(age);
*/
//=================================
/*
using FlowAndTypeControl;
Greetings g = new Greetings();
g.GreetingsUser();
 */
