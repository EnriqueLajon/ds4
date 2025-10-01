class Persona
{
    public string Nombre;
    public int Edad;
    public string NIF;

    void Cumpleaños()
    {
        Edad++;
    }

    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }
}

class Trabajador : Persona
{
    public int Sueldo;

    public Trabajador(string nombre, int edad, string nif, int sueldo)
        : base(nombre, edad, nif)
    {
        Sueldo = sueldo;
    }
}

