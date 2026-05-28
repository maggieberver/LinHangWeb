using System.ComponentModel.DataAnnotations;

namespace Segunda4F.Data {
    public class DetallePedido {
        [Key]
        public int IdDetalle { get; set; }

        public int IdPedido { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal Subtotal { get; set; }

        virtual public Pedido? Pedido { get; set; }

        virtual public Producto? Producto { get; set; }
    }
}