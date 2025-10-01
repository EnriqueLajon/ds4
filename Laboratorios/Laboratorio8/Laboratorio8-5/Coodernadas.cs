using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8_5
{
   public partial class Coodernadas
    {
        private int x;
        private int y;

        public Coodernadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public partial class Coodernadas
    {
        public void VerCoodernadas()
        {
            Console.WriteLine("Coodernadas: ({0}, {1})", x, y);
        }
    }
}
