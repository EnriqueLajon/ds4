using System;

class Program
{
    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Accesso negado - No cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso Concedido");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            checkAge(15);
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}