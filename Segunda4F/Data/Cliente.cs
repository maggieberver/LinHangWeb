using System.ComponentModel.DataAnnotations;

namespace Segunda4F.Data {
    public class Cliente {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Length(10, 10, ErrorMessage = "El teléfono debe tener exactamente 10 dígitos.")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo no es válido.")]
        public string Correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        public string Direccion { get; set; } = string.Empty;

        virtual public List<Pedido>? Pedidos { get; set; }
    }
}