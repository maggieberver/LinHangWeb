using System.ComponentModel.DataAnnotations;

namespace Segunda4F.Data {
    public class Pedido {
        [Key]
        public int IdPedido { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public string Estado { get; set; } = "Pendiente";

        public decimal Total { get; set; }

        public int IdCliente { get; set; }

        virtual public Cliente? Cliente { get; set; }

        virtual public List<DetallePedido>? Detalles { get; set; }
    }
}