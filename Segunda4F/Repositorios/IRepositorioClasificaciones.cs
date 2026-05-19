using Segunda4F.Data;

namespace Segunda4F.Repositorios
{
    public interface IRepositorioClasificaciones
    {
        Task AgregarClasificacion(Clasificacion clasificacion);
        Task<List<Clasificacion>> ObtenerClasificaciones();
        Task<Clasificacion?> ObtenerClasificacionPorId(int id);
        Task ActualizarClasificacion(Clasificacion clasificacion);
        Task EliminarClasificacion(int id);
    }
}
