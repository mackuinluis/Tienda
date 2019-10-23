namespace Tienda.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Categoria Categoria { get; set; }
        public int? CategoriaId { get; set; }
    }
}