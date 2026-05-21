using Microsoft.EntityFrameworkCore;
using Segunda4F.Data;

namespace Segunda4F.Repositorios
{
    public class RepositorioHabitos(DirectorioDBContext context) : IRepositorioHabitos
    {
        private readonly DirectorioDBContext _context = context;

        public async Task AgregarHabito(Habito habito)
        {
            await _context.Habitos.AddAsync(habito);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Habito>> ObtenerHabitos()
        {
            return await _context.Habitos.ToListAsync();
        }

        public async Task<Habito?> ObtenerHabitoPorId(int id)
        {
            return await _context.Habitos.FindAsync(id);
        }

        public async Task ActualizarHabito(Habito habito)
        {
            _context.Habitos.Update(habito);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarHabito(int id)
        {
            var habito = await _context.Habitos.FindAsync(id);
            if (habito!= null)
            {
                _context.Habitos.Remove(habito);
                await _context.SaveChangesAsync();
            }
        }
    }
}
