// A METHOD is a named, reusable block of logic. A CLASS bundles data together 
// with the methods that act on it. In C# methods always live inside a class,
// so we meet them together. 

// Note the layout: the runnable statements come first, and the class is
// defined lower down. 

using System;

// A method that gives a value back uses `return` and names the type it returns
// (here, `int`). `a` and `b` are its parameters.
int Add(int a, int b)
{
    return a + b;
}

// A method that returns nothing is `void`. A parameter can have a default,
// used when the caller leaves it out. 
void Greet(string name, string greeting = "Hello")
{
    Console.WriteLine($"{greeting}, {name}!");
}

Console.WriteLine($"3 + 4 = {Add(3,4)}");
Greet("Sam");           // Uses the default greeting
Greet("Sam", "Aloha");  // Overrides it

Console.WriteLine("---");

// Create objects from the class with `new`, then call their methods.
BankAccount account = new BankAccount("Sam");
Console.WriteLine($"Balance: {account.Balance}");   // 0
account.Deposit(50);
account.Deposit(25);
Console.WriteLine($"Balance: {account.Balance}");   // 75
Console.WriteLine($"Empty? {account.IsEmpty()}");   // False

// A class is a blueprint. Fields hold each object's data; methods act on it.
class BankAccount
{
    public string Owner;    // fields: this object's data
    public int Balance;

    // The constructor runs when you write `new BankAccount(...)`.
    public BankAccount(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    // Methods act on the object's own fields.
    public void Deposit(int amount)
    {
        Balance += amount;
    }
    public bool IsEmpty()
    {
        return Balance == 0;
    }
}
