using System;
using Modules;

class Program
{
    public static void Main(string[] args)
    {
        var name = "C# Replit";
        var P = new Module();
        P.DoMain(name);

        // sample
        var i = 123;
        var j = 456;
        var result = Calc.Add(i, j);
        Console.WriteLine($"result = {result}");

    }
}
