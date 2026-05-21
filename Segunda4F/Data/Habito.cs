using System.ComponentModel.DataAnnotations;

namespace Segunda4F.Data
{
    public class Habito
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del hábito es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del hábito no puede exceder los 100 caracteres.")]
        public string? Nombre { get; set; }=string.Empty;
        virtual public List<Persona>? Personas { get; set; }
    }
}
