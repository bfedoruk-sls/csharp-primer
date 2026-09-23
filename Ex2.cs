using System;

// Console.ReadLine gives you the text. To do arithmetic or numeric comparisons you must 
// PARSE it into a number first.
Console.Write("Enter your score out of 50: ");
string? input = Console.ReadLine();

// int.TryParse is the safe way to convert: it returns true on success and puts the number
// into ``score''. (int.Parse also converts, but it CRASHES on bad text.)
if (int.TryParse(input, out int score))
{
    // Watch out: int / int throws away the decimals. Cast one side to double so the
    // division keeps them. (double) score / 50 -> a real fraction.
    double percent = (double) score / 50 * 100;
    Console.WriteLine($"That's {percent}%.");

    // if / else if / else runs FIRST branch whose condition is true. 
    if (percent >= 90)
        Console.WriteLine("Grade: A");
    else if (percent >= 50)
        Console.WriteLine("Grade: Pass");
    else
        Console.WriteLine("Grade: Fail");
}
else
{
    Console.WriteLine("That wasn't a whole number.");
}

// A `switch` is cleaner than a long if/else chain when you're matching one value 
// against a set of fixed options. Every case needs its own `break. 
Console.Write("Pick a letter grade (A/B/C): ");
string? grade = Console.ReadLine()?.ToUpper();  // ?. safely calls ToUpper even if null

switch (grade)
{
    case "A": 
        Console.WriteLine("Excellent!");
        break;
    case "B":
        Console.WriteLine("Good.");
        break;
    case "C":
        Console.WriteLine("Passing.");
        break;
    default:        // the equivalent of `else` in an if/else chain
        Console.WriteLine("Not a grade I recognize.");
        break;
}