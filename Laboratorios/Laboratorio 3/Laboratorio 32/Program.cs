using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double radio, area;

        Console.Write("Introduce el radio del círculo: ");
        radio = Convert.ToDouble(Console.ReadLine());

        area = Math.PI * (radio * radio);

        Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);
    }
}
