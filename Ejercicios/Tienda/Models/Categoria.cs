using System.Collections.Generic;

namespace Tienda.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
}