![Banner](banner.png)

A short, hands-on introduction to C# for students with no programming
background. Five small example files, each teaching one idea, that build toward
a capstone project: a working console game of **Blackjack**.

## Who this is for

Anyone starting a course that uses C# — or anyone wanting a fast, practical
refresher in the first weeks of term. It assumes you have never written a line
of code. If you already know another language, you can move quickly.

## Setting up

C# runs on the .NET SDK. Install **.NET 10 or newer** from
[dotnet.microsoft.com/download](https://dotnet.microsoft.com/download). Check
it's there by opening a terminal and running:

```
dotnet --version
```

If that prints `10.` or higher, you're ready. An editor such as Visual Studio
Code (with the C# Dev Kit extension) or Visual Studio makes editing easier, but
any text editor works.

## The files

| File | Topic | What you'll be able to do |
|---|---|---|
| `Ex1.cs` | Basics | Print output, declare typed variables, interpolate strings |
| `Ex2.cs` | Decisions | Parse input to numbers; branch with `if` and `switch` |
| `Ex3.cs` | Loops | Repeat work with `for`, `foreach`, and `while` |
| `Ex4.cs` | Methods and classes | Write methods and build your own class |
| `Ex5.cs` | Collections | Store data in a `List<T>` and a `Dictionary<TKey,TValue>` |
| `Blackjack.cs` | Capstone project | Build a playable game of Blackjack |

Work through them in order. Each example assumes the ones before it.

## How to run an example

Since .NET 10, you can run a single C# file directly — no project setup needed.
From a terminal, in this folder (which has no project file):

```
dotnet run Ex1.cs
```

The first run compiles and caches; later runs are quick. C# is a *compiled*
language, so mistakes are caught before anything runs — if the file won't
build, the compiler prints the file, the line, and an error code (like
`CS0103`) instead of running.

> On .NET 9 or earlier, single-file run isn't available. Create a project with
> `dotnet new console`, paste an example into `Program.cs`, and run `dotnet run`.

## How to use this primer

Reading code is not the same as understanding it. For each example:

1. Read the file and **predict what it prints**, before running it.
2. Run it. Compare the output to your prediction.
3. Where you were wrong, that gap is the thing worth studying.
4. Change something — a value, a condition — and predict again.

Breaking the examples on purpose is encouraged. Compiler errors are
information, and learning to read them early pays off more than anything else
here.

## The capstone project

`Blackjack.cs` is a guided scaffold for the card game. You're dealt two cards;
you **hit** to draw another or **stand** to hold. Go over 21 and you bust.
After you stand, the dealer draws to at least 17, and whoever is closest to 21
without busting wins.

Each concept from the examples powers a piece of it:

- Console I/O (`Ex1`) → ask hit-or-stand and show the table
- `if`/`switch` (`Ex2`) → read the player's choice
- Loops (`Ex3`) → keep dealing until a stand or a bust
- Methods and classes (`Ex4`) → the `Card`, `Deck`, and `Hand` types
- `List<T>` (`Ex5`) → the deck and each player's hand

The scaffold hands you the `Card` and `Deck` classes and the deal-and-play loop
already wired, so your effort goes into the interesting part: computing a
hand's total. The tricky bit — an Ace counts as 11 *or* 1, whichever avoids a
bust — is spelled out as a hint in the file. Build one piece at a time.

## Errors you will probably hit

**`; expected` (`CS1002`)** — C# statements end in a semicolon; you left one
off.

**`CS0103: The name 'x' does not exist`** — a typo, or you used a variable
before declaring it. C# is case-sensitive, so `Score` and `score` are two
different names.

**Integer division surprises** — `7 / 2` is `3`, not `3.5`, because both sides
are whole numbers. Cast one to `double` first: `(double)7 / 2`. (This is the
`Ex2` lesson.)

**`CS0163: control cannot fall through`** — a `switch` case is missing its
`break`. Every case needs one.

**`NullReferenceException`** — you used something that was `null`, often the
result of `Console.ReadLine()` when there's no input. That's why the examples
store it in a `string?`.

## Getting help

Bring your code — working or broken — to a Coding and Programming (C&P)
appointment or drop-in. Book on [[QuadC](https://ontariotech.quadc.io)] or email [[benjamin.fedoruk@ontariotechu.ca](mailto://benjamin.fedoruk@ontariotechu.ca)].
Drop-in times for Coding and Programming Study Hall are posted [[at this link](https://docs.google.com/spreadsheets/d/1HoCmjlVqAKp0YtidoM_r6wVRqoinUT5GJ64THxeA5SE/edit?gid=0#gid=0)].

## About

This primer is part of the Coding and Programming (C&P) Primers series from the
Teaching and Learning Centre at Ontario Tech University. Written by
Benjamin D. Fedoruk, Subject Specialist in Mathematics and Coding &
Programming.
