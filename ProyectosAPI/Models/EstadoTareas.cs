using System.ComponentModel.DataAnnotations;

namespace ProyectosAPI.Models
{
    public class EstadoTareas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;
    }
}
