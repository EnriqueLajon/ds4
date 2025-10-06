using Laboratorio_95;
internal class Program
{
    private static void Main(string[] args)
    {

        Aleatorios aleatorios = new Aleatorios();
        int[] arregloSinRepetidos = aleatorios.GenerarArregloSinRepetidos(10, 1, 50);

        Console.WriteLine($"Arreglo sin repetidos: [{string.Join(", ", arregloSinRepetidos)}]");
        Console.WriteLine();
    }
}
 
