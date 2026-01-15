using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var fibonacci = new List<int> {1, 1, 2};

        while(fibonacci.Count < 20)
        {
            var previous1 = fibonacci[fibonacci.Count - 1];
            var previous2 = fibonacci[fibonacci.Count - 2];
            //Console.WriteLine($"The current number is {fibonacci.Max()}");
            fibonacci.Add(previous1 + previous2);
        }
        foreach(var number in fibonacci)
        {
            Console.WriteLine($"{number}");
        }
    }
}