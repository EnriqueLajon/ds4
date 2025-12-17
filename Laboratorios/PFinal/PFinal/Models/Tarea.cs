using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFinal.Models
{
    public class Tarea
    {
        [Key]
        public int IdTarea { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaLimite { get; set; }

        public bool Completada { get; set; }

        // Relación con Prioridad
        public int? IdPrioridad { get; set; }

        [ForeignKey("IdPrioridad")]
        public Prioridad Prioridad { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}

