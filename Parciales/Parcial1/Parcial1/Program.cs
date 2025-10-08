using System;

class Program
{
    public static void Main(string[] args)
    {
        int n;
        // solicitamos el tamaño de la matriz
        Console.Write("Ingrese el valor de N (debe ser par y >= 4): ");
        n = Convert.ToInt32(Console.ReadLine());
        // aqui validamos
        while (n < 4 || n % 2 != 0)
        {
            if (n < 4)
            {
                Console.WriteLine("Error: N debe ser mayor o igual a 4");
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine("Error: N debe ser par (divisible entre 2)");
            }
            Console.Write("Ingrese el valor de N (debe ser par y >= 4): ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nDimension dinamica: N x N = " + n);

        int[,] matriz = new int[n, n];

        Random random = new Random();

        // Calcular las 2 filas del medio
        int fila1 = (n / 2) - 1;
        int fila2 = n / 2;

        
        int i = 0;
        while (i < n)
        {
            int j = 0;
            while (j < n)
            {
                // Solo las 2 filas del medio tienen aleatorios en las columnas del medio
                if ((i == fila1 || i == fila2) && j > 0 && j < n - 1)
                {
                    matriz[i, j] = random.Next(101, 201);
                }
                else
                {
                    matriz[i, j] = 0;
                }
                j = j + 1;
            }
            i = i + 1;
        }

        Console.WriteLine();

        int sumaTotal = 0;
        i = 0;
        while (i < n)
        {
            int j = 0;
            while (j < n)
            {
                Console.Write(matriz[i, j] + "\t");
                sumaTotal = sumaTotal + matriz[i, j];
                j = j + 1;
            }
            Console.WriteLine();
            i = i + 1;
        }

        Console.WriteLine("\n" + sumaTotal);
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}