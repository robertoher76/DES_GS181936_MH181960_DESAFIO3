using System.ComponentModel.DataAnnotations;

namespace ProyectosAPI.Models
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; } = string.Empty;

        public int? EstadoId { get; set; }

        public int? ProyectoId { get; set; }

        public Proyecto? Proyecto { get; set; }
        public EstadoTareas? EstadoTareas { get; set; }
    }
}
