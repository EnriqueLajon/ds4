using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PFinal.Models
{
    public class GestorContext : DbContext
    {
        public GestorContext() : base("name=ConexionGestor")
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Prioridad> Prioridades { get; set; }
    }
}
