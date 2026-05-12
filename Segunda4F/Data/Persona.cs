using System.ComponentModel.DataAnnotations;

namespace Segunda4F.Data
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Length(10,10, ErrorMessage = "El teléfono debe tener exactamente 10 dígitos.")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo no es válido.")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El género es obligatorio.")]
        public string? Genero { get; set; }
    }
}
