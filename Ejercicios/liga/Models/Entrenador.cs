using System.ComponentModel.DataAnnotations;

namespace liga.Models
{
    public class Entrenador
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string PuebloOrigen { get; set; }
    }
}