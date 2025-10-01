using Laboratorio8_2;
using static Laboratorio8_2.Cuenta;

internal class Program
{
    private static void Main(string[] args)
    {
        const string CUENTA = "100";
        Cuenta cuenta = new Cuenta(CUENTA);
        CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);
        CuentaAhorro cuentaAhorro = new CuentaAhorro(CUENTA);
        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();
    }
}