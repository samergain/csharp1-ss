
/*

Practice number sizes and ranges
1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.

Composite Formatting to learn how to align text in a console application
 */
using _02UnderstandingTypes;


Console.WriteLine("  Type       |  MinValue                      |  MaxValue                      |  Size(bytes) ");
Console.WriteLine("----------------------------------------------------------------------------------------------");
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  sbyte", $"{sbyte.MinValue}", $"{sbyte.MaxValue}",$" {sizeof(sbyte)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  byte", $"{byte.MinValue}", $"{byte.MaxValue}", $" {sizeof(byte)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  short", $"{short.MinValue}", $"{short.MaxValue}", $" {sizeof(short)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  ushort", $"{ushort.MinValue}", $"{ushort.MaxValue}", $" {sizeof(ushort)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  int", $"{int.MinValue}", $"{int.MaxValue}", $" {sizeof(int)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  uint", $"{uint.MinValue}", $"{uint.MaxValue}", $" {sizeof(uint)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  long", $"{long.MinValue}", $"{long.MaxValue}", $" {sizeof(long)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  ulong", $"{ulong.MinValue}", $"{ulong.MaxValue}", $" {sizeof(ulong)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  float", $"{float.MinValue}", $"{float.MaxValue}", $" {sizeof(float)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  double", $"{double.MinValue}", $"{double.MaxValue}", $" {sizeof(double)}"));
Console.WriteLine(String.Format("{0,-12} | {1,-30} | {2,-30} | {3,-12}", "  decimal", $"{decimal.MinValue}", $"{decimal.MaxValue}", $" {sizeof(decimal)}"));
Console.WriteLine("----------------------------------------------------------------------------------------------");


/*
 *2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
Input: 1
Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
microseconds = 3155673600000000000 nanoseconds
Input: 5
Output: 5 centuries = 500 years = 182621 days = 4382904 hours = 262974240
minutes = 15778454400 seconds = 15778454400000 milliseconds = 15778454400000000
microseconds = 15778454400000000000 nanoseconds
*/
Century test = new();
test.ConvertCentury(1);