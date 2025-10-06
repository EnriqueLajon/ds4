internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el primer lado: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        double lado3 = double.Parse(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo EQUILÁTERO (3 lados iguales)");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo ISÓSCELES (2 lados iguales)");
            }
            else
            {
                Console.WriteLine("Es un triángulo ESCALENO (todos los lados diferentes)");
            }
        }
        else
        {
            Console.WriteLine("Los valores ingresados NO forman un triángulo válido");
        }
        Console.WriteLine();
    }
}
