using Segunda4F.Data;

namespace Segunda4F.Repositorios
{
    public interface IRepositorioHabitos
    {
        Task AgregarHabito(Habito habito);
        Task<List<Habito>> ObtenerHabitos();
        Task<Habito?> ObtenerHabitoPorId(int id);
        Task ActualizarHabito(Habito habito);
        Task EliminarHabito(int id);
    }
}
