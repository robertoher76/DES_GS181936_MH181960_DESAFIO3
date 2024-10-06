using System.ComponentModel.DataAnnotations;

namespace ProyectosAPI.Models
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Descripcion { get; set; } = string.Empty;       
        
        public int? ProyectoId { get; set; }

        public Proyecto? Proyecto { get; set; }

        public int? EstadoTareasId { get; set; }

        public EstadoTareas? EstadoTareas { get; set; }
    }
}
