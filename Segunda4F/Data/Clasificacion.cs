using System.ComponentModel.DataAnnotations;

namespace Segunda4F.Data
{
    public class Clasificacion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;
        virtual public List<Persona>? Personas { get; set; } 
    }
}
