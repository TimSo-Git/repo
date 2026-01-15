using System;

class Program{
    static void Main(){
        string greeting = "Hello everyone, this is YOUR daily dose of internet";

        Console.WriteLine(greeting.StartsWith("Hello"));
        Console.WriteLine(greeting.StartsWith("Goodbye"));
        Console.WriteLine(greeting.EndsWith("internet"));
        Console.WriteLine(greeting.EndsWith("intranet"));
    }
}