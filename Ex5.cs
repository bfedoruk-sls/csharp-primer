// List<T> is a resizable, ordered collection. Dictionary<TKey, TValue> looks
// values up by a key. The <...> says what type of thing lives inside. 

using System;
using System.Collections.Generic;

// --- List<T> ---
List<string> names = new List<string> { "Ada", "Alan", "Grace" };

Console.WriteLine(names[0]);                // Ada -- index 0 is the first item
Console.WriteLine(names.Count);             // 3
names.Add("Edgar");                         // add to the end
Console.WriteLine(names.Contains("Grace")); // True

foreach (string person in names)
{
    Console.WriteLine($" - {person}");
}

Console.WriteLine("---");

// --- Dictionary<TKey, TValue> ---
Dictionary<string, int> ages = new Dictionary<string, int>
{
    ["Ada"] = 36,
    ["Grace"] = 42
};

Console.WriteLine(ages["Ada"]); // 36 - look up by key
ages["Alan"] = 41;              // add a new key/value pair

// TryGetValue checks for a key without crashing if its missing.
if (ages.TryGetValue("Grade", out int graceAge))
{
    Console.WriteLine($"Grace is {graceAge}");
}

Console.WriteLine("---");

// --- The counting pattern: how many times does each item appear? ---
string[] rolls = { "red", "blue", "red", "green", "red" };
Dictionary<string, int> counts = new Dictionary<string, int>();
foreach (string colour in rolls)
{
    if (counts.ContainsKey(colour))
        counts[colour]++;   // seen before: add one
    else
        counts[colour] = 1; // first time: start at one
}
Console.WriteLine($"red appears {counts["red"]} times."); // 3