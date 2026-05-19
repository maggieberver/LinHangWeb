using Microsoft.EntityFrameworkCore;
using Segunda4F.Data;

namespace Segunda4F.Repositorios
{
    public class RepositorioClasificaciones(DirectorioDBContext context) : IRepositorioClasificaciones
    {
        private readonly DirectorioDBContext _context = context;

        public async Task AgregarClasificacion(Clasificacion clasificacion)
        {
            await _context.Clasificaciones.AddAsync(clasificacion);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Clasificacion>> ObtenerClasificaciones()
        {
            return await _context.Clasificaciones.ToListAsync();
        }

        public async Task<Clasificacion?> ObtenerClasificacionPorId(int id)
        {
            return await _context.Clasificaciones.FindAsync(id);
        }

        public async Task ActualizarClasificacion(Clasificacion clasificacion)
        {
            _context.Clasificaciones.Update(clasificacion);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarClasificacion(int id)
        {
            var clasificacion = await _context.Clasificaciones.FindAsync(id);
            if (clasificacion != null)
            {
                _context.Clasificaciones.Remove(clasificacion);
                await _context.SaveChangesAsync();
            }
        }
    }
}
