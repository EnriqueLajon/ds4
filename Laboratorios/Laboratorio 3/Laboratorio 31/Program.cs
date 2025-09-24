using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, operacion;

        Console.Write("Introduce el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        operacion = (primerNumero + segundoNumero)*(primerNumero - segundoNumero);

        Console.WriteLine("El resultado de la operacion de (a+b) (a-b) es de: {0}", operacion);
    }
}
