using System.ComponentModel.DataAnnotations;

namespace ProyectosAPI.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Descripcion { get; set; } = string.Empty;
    }
}
