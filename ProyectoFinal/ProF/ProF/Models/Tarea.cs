using System;
using System.ComponentModel.DataAnnotations;

namespace Prof.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha límite es requerida")]
        [DataType(DataType.Date)]
        public DateTime FechaLimite { get; set; }

        public EstadoTarea Estado { get; set; }

        public PrioridadTarea Prioridad { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaCompletada { get; set; }
    }

    public enum EstadoTarea
    {
        Pendiente = 0,
        Completada = 1
    }

    public enum PrioridadTarea
    {
        Baja = 0,
        Media = 1,
        Alta = 2
    }
}