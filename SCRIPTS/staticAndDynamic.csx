// using System;
using Internal;

class Greeter {
    private string name; // declaring a var inside a class, property/attribute: allows other methods to communicate with variable "name"?
    public Greeter(string name) { // class method (constructor), to be called when setting up a class instance,
        this.name = name; // assigns the variable's property to current class instance
    }
    public void Greet() { // class method, called on Greeter.Greet or [instance name].Greet
        // no parameters, references "this." instance property:
        Console.WriteLine($"\"Greet\" method activated: {this.name}.");
    }

    // static makes it act like a function instead of a class; no instances allowed:
    private static string nameStatic = "Steve S"; // set default variable?
    public static string GreetDefault() {
        return $"Hello, {nameStatic}";
    }
}

Console.WriteLine();
Greeter g1 = new Greeter("Steve G"); // initializes "Steve G" as a property of the g1 class instance
Greeter g2 = new Greeter("Steve C");
g1.Greet(); // calls the printing method ".Greet()"
g2.Greet();

Console.WriteLine();
// fails, as the .nameStatic property can't be directly accessed, due to "private" modifier:
// Console.WriteLine(Greeter.nameStatic);
Console.WriteLine(Greeter.GreetDefault()); // no created class instance, only activates the class method like a function

Console.WriteLine("\n");
