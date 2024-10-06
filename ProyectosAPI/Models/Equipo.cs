using System.ComponentModel.DataAnnotations;

namespace ProyectosAPI.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(250)]
        [MinLength(3)]
        public string Descripcion { get; set; } = string.Empty;
    }
}
