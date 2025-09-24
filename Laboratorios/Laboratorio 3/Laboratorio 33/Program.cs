using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int lado1, lado2, perimetro;

        Console.Write("Introduce el primer lado del rectángulo: ");
        lado1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo lado del rectángulo: ");
        lado2 = Convert.ToInt32(Console.ReadLine());

        perimetro = 2 * (lado1 + lado2);

        Console.WriteLine("El perímetro del rectángulo con lados {0} y {1} es: {2}", lado1, lado2, perimetro);
    }
}
