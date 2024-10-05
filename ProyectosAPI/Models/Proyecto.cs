using System.ComponentModel.DataAnnotations;

namespace ProyectosAPI.Models
{
    public class Proyecto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public DateOnly FechaDeInicio { get; set; }

        [Required]
        public DateOnly FechaDeFin { get; set; }

        [Required]
        public int? EquipoId { get; set; }

        public Equipo? Equipo { get; set; }
    }
}
