using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PFinal.Models
{
    public class Prioridad
    {
        [Key]
        public int IdPrioridad { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
