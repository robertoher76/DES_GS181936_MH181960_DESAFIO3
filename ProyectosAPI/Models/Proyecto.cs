using System.ComponentModel.DataAnnotations;

namespace ProyectosAPI.Models
{
    public class Proyecto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [MinLength(3)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateOnly FechaDeInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly FechaDeFin { get; set; }

        [Required]
        public int? EquipoId { get; set; }

        public Equipo? Equipo { get; set; }
    }
}
