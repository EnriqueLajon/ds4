using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> paisesYcapitales = new Dictionary<string, string>
        {
            {"Francia", "Paris"},
            {"España", "Madrid"},
            {"Italia", "Roma"}
        };

        foreach (KeyValuePair<string, string> par in paisesYcapitales)
        {
            Console.WriteLine("La capital de " + par.Key + " es " + par.Value + ".");
        }
        Console.ReadKey();
    }
}