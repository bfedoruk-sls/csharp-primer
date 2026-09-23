using System;

// A `for` loop has three parts: start, condition, and step. This one counts.
for (int i = 1; i <= 5; i++) // i++ means "add 1 to i"
{
    Console.WriteLine($"Count: {i}");
}

Console.WriteLine("---");

// An array holds a fixed row of values. A `foreach` loop visits each in turn - you get the
// ITEM directly, with no index to manage.
string[] fruits = { "apple", "banana", "cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine($"I have a {fruit}.");
}

Console.WriteLine("---");

// A `while` loop runs as long as its condition stays true. `total` is an accumulator. 
// It builds a result up across the loop. 
int total = 0;
int n = 1;
while (n <= 5)
{
    total += n; // shorthand for `total = total + n`
    n++;        // without this, the loop would never end
}
Console.WriteLine($"1 to 5 adds up to {total}.");

Console.WriteLine("---");

// `break` stops a loop immediately; `continue` skips the rest of this pass. 
for (int i = 1; i <= 10; i++)
{
    if (i == 7) break;              // stop the loop once we reach 7
    if (i % 2 == 0) continue;       // % is the remainder; skip the even numbers
    Console.WriteLine($"Odd: {i}"); // prints 1, 3, 5
}