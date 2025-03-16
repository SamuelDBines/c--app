using System;

// Console.WriteLine("Hello, World!");

class Program {
    static void Main() {
        Console.WriteLine("Hello, Mac!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine($"Hello, {name}! This is a C# app running on macOS.");
    }
}