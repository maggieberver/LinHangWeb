using Microsoft.EntityFrameworkCore;
using Segunda4F.Data;

namespace Segunda4F.Repositorios
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        readonly DirectorioDBContext _context;
        public RepositorioPersonas(DirectorioDBContext context)
        {
            _context = context;
        }

        public Task ActualizarPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task AgregarPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public Task EliminarPersona(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Persona> ObtenerPersonaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Persona>> ObtenerPersonas()
        {
            return await _context.Personas.ToListAsync();
        }
    }
}
