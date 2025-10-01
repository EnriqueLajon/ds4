using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8_2
{
    public class Cuenta
    {
        private string idCuenta;

        public Cuenta(string prmIdCuenta)
        {
            this.idCuenta = prmIdCuenta;
            System.Console.WriteLine("Constructor Clase Base para cuenta {0}", prmIdCuenta);
        }

        public virtual void CalcularIntereses()
        { 
            System.Console.WriteLine("Cuenta.CalcularIntereses() efectuando para la cuenta {0}", this.idCuenta);
        }

        public string getIdCuenta()
        { 
            return this.idCuenta;
        }

        public class CuentaCorriente : Cuenta
        { 
            public CuentaCorriente(string prmIdCuenta) : base(prmIdCuenta)
            {
            }

            public override void CalcularIntereses() {
                System.Console.WriteLine("CuentaCorriente.CalcularIntereses() efectuando para " + "la cuenta {0}", this.getIdCuenta());
            }
        }
        public class CuentaAhorro : Cuenta
        { 
            public CuentaAhorro(string prmIdCuenta) : base(prmIdCuenta)
            {
            }

            public override void CalcularIntereses() {
                System.Console.WriteLine("CuentaAhorro.CalcularIntereses() efectuando para " + "la cuenta {0}", this.getIdCuenta());
            }
        }
    }
}
