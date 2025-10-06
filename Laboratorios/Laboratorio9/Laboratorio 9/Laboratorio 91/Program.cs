using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double precio = 0;
        string formaPago = "";
        string identificacion = "";

        while (true)
        {
            Console.Write("Ingrese el precio del producto: $");
            if (double.TryParse(Console.ReadLine(), out precio) && precio > 0)
            {
                break;
            }
            Console.WriteLine("El precio debe ser un número positivo. Inténtelo nuevamente.\n");
        }

        while (true)
        {
            Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
            formaPago = Console.ReadLine().ToLower();

            if (formaPago == "efectivo" || formaPago == "tarjeta")
            {
                break;
            }
            Console.WriteLine("Forma de pago inválida. Debe ser 'efectivo' o 'tarjeta'. Inténtelo nuevamente.\n");
        }

        while (true)
        {
            Console.Write("Ingrese el número de identificación: ");
            identificacion = Console.ReadLine();

            if (formaPago == "tarjeta")
            {
                if (identificacion.Length == 16 && long.TryParse(identificacion, out _))
                {
                    break;
                }
                Console.WriteLine("Si paga con tarjeta, la identificación debe tener exactamente 16 dígitos numéricos.\n");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("\nResumen:");
        Console.WriteLine($"Precio: ${precio:F2}");
        Console.WriteLine($"Forma de pago: {formaPago}");
        Console.WriteLine($"Identificación: {identificacion}");
        Console.WriteLine();
    }
}
