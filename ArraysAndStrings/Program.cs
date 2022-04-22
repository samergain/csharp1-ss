/*
Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
string is immutable while StringBuilder can be changed and has many methods to manuplate its value. 
We use StringBuilder when our string value is expected to be changed. string would be used to hold a data that should remain unchanged.

2. What is the base class for all arrays in C#?
Array types are reference types derived from the abstract base type Array. All arrays implement IList, and IEnumerable interfaces.

3.How do you sort an array in C#?
Array class has a method for sorting called sort. 
The Array.Sort method takes array as an input and sorts the array in ascending order
To sort an array in descending order, we can use Sort.Reverse method

4.What property of an array object can be used to get the total number of elements in
an array?
array.length

5. Can you store multiple data types in System.Array?
No, the array should have one data type for all its elements. But, there's a way around that. To be able to store multiple data types,
we should declare the array type as "object". since "object" is the base class to all the other types,
the array can have a reference to any other type of object.

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
The Clone() method returns a new array (a shallow copy) object containing all the elements in the original array. 
The CopyTo() method copies the elements into another existing array. Both perform a shallow copy.
*/
using System.Collections;
ArrayList list = new ArrayList();
while (true)
{
    Console.WriteLine("Options: add to list ( + item ) | remove from list ( - item ) | clear list ( -- )");
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
            break;
        case ("--"):
            list.Clear();
            break;
        case ("xx"):
            return;
        default:
            Console.WriteLine("Undefined Option!");
            break;
    }
    foreach (string item in list)
    {
        Console.WriteLine(item);
    }
}