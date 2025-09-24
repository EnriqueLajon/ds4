using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };

        int suma = 0;

        foreach (int calificación in calificaciones)
        {
            suma += calificación;
        }

        double promedio = suma / (double)calificaciones.Count;

        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
        Console.ReadKey();
    }
}