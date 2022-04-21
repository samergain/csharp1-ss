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

/*
 * 1-
Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the
original array.
Use a loop to read values from the original array and place them in the new array. Also
print out the contents of both arrays, to be sure everything copied correctly.
*/
int[] array1 = new int[10] {1,2,3,4,5,6,7,8,9,10};
int[] array2 = new int[array1.Length];
for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
}
for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine($"item {i} in array1: {array1[i]} && item {i} in array2: {array2[i]}");
}

/*
2. Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear. The syntax should be as follows:
+ some item
- some item
--
Your program should read in the user's input and determine if it begins with a “+” or “-“ or
if it is simply “—“ . In the first two cases, your program should add or remove the string
given ("some item" in the example). If the user enters just “—“ then the program should
clear the current list. Your program can start each iteration through its loop with the
following instruction:
Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");


3. Write a method that calculates all prime numbers in given range and returns them as array
of integers
static int[] FindPrimesInRange(startNum, endNum)
{
}


4. Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
After r rotations the element at position I goes to position (I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1.
Input Output Comments
3 2 4 -1 3 2 5 6 rotated1[] = -1 3 2 4
2 rotated2[] = 4 -1 3 2
sum[] = 3 2 5 6
1 2 3 4 5 12 10 8 6 9 rotated1[] = 5 1 2 3 4
3 rotated2[] = 4 5 1 2 3
rotated3[] = 3 4 5 1 2
sum[] = 12 10 8 6 9


5. Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one.
Input Output
2 1 1 2 3 3 2 2 2 1 2 2 2
1 1 1 2 3 1 3 3 1 1 1
4 4 4 4 4 4 4 4
0 1 1 5 2 2 6 3 3 1 1


7. Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them
Input Output
4 1 1 4 2 3 4 4 1 2 4 9 3 The number 4 is the most frequent (occurs 5 times)
7 7 7 0 2 2 2 0 10 10 10 The numbers 2, 7 and 10 have the same maximal
frequence (each occurs 3 times). The leftmost of them is 7.
*/