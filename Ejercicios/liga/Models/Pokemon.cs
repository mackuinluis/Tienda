using System.ComponentModel.DataAnnotations;

namespace liga.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Foto { get; set; }
        
    }
}