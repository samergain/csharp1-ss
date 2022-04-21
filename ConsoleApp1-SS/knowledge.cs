/*Understanding Data Types
Test your Knowledge
1. What type would you choose for the following “numbers”?
    A person’s telephone number  =  string
    A person’s height  = float
    A person’s age = ushort
    A person’s gender (Male, Female, Prefer Not To Answer) = enum
    A person’s salary = decimal
    A book’s ISBN = string
    A book’s price = decimal
    A book’s shipping weight = float
    A country’s population = uint
    The number of stars in the universe = ulong
    The number of employees in each of the small or medium businesses in the
    United Kingdom (up to about 50,000 employees per business) = ushort
2.What are the difference between value type and reference type variables? What is
boxing and unboxing?
    value vs. reference types:
    1) value holds the actual value for the variable, while reference is pointing to the data location in memory
    2) value type is stored in stack memory, reference is stored in heap memory
    3) value type is not collected by garbage collector, reference will be collected
    4) value type is created using Struct or Enum, reference is created using Class, Interface, Delegate, Array
    5) value type doesn't accept NULL, reference does

    boxing is converting value type to reference
    unboxing is converting reference to type

3. What is meant by the terms managed resource and unmanaged resource in .NET
    Managed resources are those that are pure .NET code and managed by the runtime and are under its direct control.
    Unmanaged resources are those that are not. File handles, pinned memory, COM objects, database connections etc.
4. Whats the purpose of Garbage Collector in .NET? 
    The garbage collector manages the allocation and release of memory for an application
*/

/*Playing with Console App
Modify your console application to display a different message. Go ahead and
intentionally add some mistakes to your program, so you can see what kinds of error
messages you get from the compiler. The more familiar you are with these messages, and
what causes them, the better you'll be at diagnosing problems in your programs that you /
didn't/ intend to add!
Using just the ReadLine and WriteLine methods and your current knowledge of variables,
you can have the user pass in quite a few bits of information. Using this approach, create a
console application that asks the user a few questions and then generates some custom
output for them. For instance, your program could generate their "hacker name" by asking
them their favorite color, their astrology sign, and their street address number. The result
might be something like "Your hacker name is RedGemini480."
    
    answer in: Program.cs
*/
