
using Laboratorio_94;
internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.WriteLine($"Número aleatorio entre 2 números: {aleatorios.GenerarEntre2Numeros(10, 50)}");

        int[] arreglo = aleatorios.GenerarArregloAleatorio(5, 1, 20);
        Console.WriteLine($"Arreglo aleatorio: [{string.Join(", ", arreglo)}]");

        Console.WriteLine();
    }
}
