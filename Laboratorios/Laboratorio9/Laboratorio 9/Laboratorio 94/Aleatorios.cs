using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_94;
public class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    // Generar un número aleatorio entre dos números
    public int GenerarEntre2Numeros(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    // Generar un arreglo de números aleatorios entre dos números
    public int[] GenerarArregloAleatorio(int cantidad, int min, int max)
    {
        int[] arreglo = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = random.Next(min, max + 1);
        }

        return arreglo;
    }

    // Generar un arreglo de números aleatorios sin repetidos
    public int[] GenerarArregloSinRepetidos(int cantidad, int min, int max)
    {
        // Verificar que sea posible generar la cantidad solicitada
        if (cantidad > (max - min + 1))
        {
            throw new ArgumentException("No es posible generar tantos números únicos en el rango dado");
        }

        HashSet<int> numerosUnicos = new HashSet<int>();

        while (numerosUnicos.Count < cantidad)
        {
            int numero = random.Next(min, max + 1);
            numerosUnicos.Add(numero);
        }

        return numerosUnicos.ToArray();
    }
}