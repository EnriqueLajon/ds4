using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero, multiplicacion;

        Console.Write("Introduce el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        multiplicacion = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);

        Console.WriteLine("El resultado de la operacion es de: {0}", multiplicacion);
    }
}
