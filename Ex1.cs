using System;
// Run it with: dotnet run Ex1.cs (needs .NET 10 SDK or newer)

// Console.WriteLine prints a line of text to the screen
Console.WriteLine("Hello! Let's look at some C# basics.");

// C# is statistically typed: every variable has a type. You can name the type explicitly,
//  or write `var` and let the compiler infer it from the value. 
string name = "Ada";
int age = 36;           // whole number
double height = 1.70;   // number with a decimal point
bool isStudent = true;  // true or false

// A $"..." string is INTERPOLATED: put a variable in {braces} and its value is dropped 
// straight into the text. 
Console.WriteLine($"{name} is {age} years old and {height} m tall.");

// `var` here still makes an int - it's just inferred from the 90. 
var score = 90;
Console.WriteLine($"Score: {score}. Student? {isStudent}");

// Reading input. Console.ReadLine() returns the typed text -- but it can be null (for 
// example if there's no more input), so we store it in `string?` where the ? means "might 
// be null". 
Console.Write("What's your name? "); // Write, unlike WriteLine, stays on the line
string? reply = Console.ReadLine();
Console.WriteLine($"Nice to meet you, {reply}!");