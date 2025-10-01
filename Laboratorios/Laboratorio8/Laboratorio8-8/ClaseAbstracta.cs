using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8_8
{
   abstract class ClaseAbstracta
    {
        //se fuerza la herencia de la clave para definir estos metodos
        abstract protected string tomarValor();
        abstract public string prefixValor(string prefix);
        //metodo comun
        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }
    }
    class ClaseConcreta1 : ClaseAbstracta
    { 
        protected override string tomarValor()
        {
            return "ClaseConcreta1";
        }
        public override string prefixValor(String prefix)
        {
            return $"{prefix}ClaseConcreta1";
        }
    }
    class ClaseConcreta2 : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcreta2";
        }
        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcreta2";
        }
    }
}
