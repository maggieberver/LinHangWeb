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

        public async Task ActualizarPersona(Persona persona)
        {
            var personaExistente = await _context.Personas.FindAsync(persona.Id);
            if (personaExistente == null)
            {
                throw new Exception("Persona no encontrada");
            }
            personaExistente.Nombre = persona.Nombre;
            personaExistente.Telefono = persona.Telefono;
            personaExistente.Correo = persona.Correo;
            personaExistente.Genero = persona.Genero;
            personaExistente.Habitos = persona.Habitos;
            await _context.SaveChangesAsync();
        }

        public async Task AgregarPersona(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
        }

        public async Task EliminarPersona(int id)
        {
            await _context.Personas.Where(p => p.Id == id).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }

        public async Task<Persona?> ObtenerPersonaPorId(int id)
        {
            return await _context.Personas.AsNoTracking().Include(a=>a.Habitos).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Persona>> ObtenerPersonas()
        {
            return await _context.Personas.AsNoTracking().Include(c => c.Clasificacion).Include(a => a.Habitos).ToListAsync();
        }
    }
}
