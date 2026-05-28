using System.ComponentModel.DataAnnotations;

namespace Segunda4F.Data {
    public class Producto {
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        [Range(1, 10000, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal Precio { get; set; }

        public string Categoria { get; set; } = string.Empty;

        public bool Disponible { get; set; } = true;

        virtual public List<DetallePedido>? Detalles { get; set; }
    }
}