using Segunda4F.Data;

namespace Segunda4F.Repositorios
{
    public interface IRepositorioPersonas
    {
        Task AgregarPersona(Persona persona);
        Task<List<Persona>> ObtenerPersonas();
        Task<Persona> ObtenerPersonaPorId(int id);
        Task ActualizarPersona(Persona persona);
        Task EliminarPersona(int id);
    }
}
