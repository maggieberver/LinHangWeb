using Microsoft.EntityFrameworkCore;
using Segunda4F.Data;

namespace Segunda4F.Repositorios {
    public class RepositorioClientes : IRepositorioClientes {
        readonly DirectorioDBContext _context;

        public RepositorioClientes(DirectorioDBContext context) {
            _context = context;
        }

        public async Task<List<Cliente>> ObtenerClientes() {
            return await _context.Clientes
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Cliente?> ObtenerClientePorId(int id) {
            return await _context.Clientes
                .FirstOrDefaultAsync(c => c.IdCliente == id);
        }

        public async Task<Cliente?> ObtenerClientePorTelefonoOCorreo(string telefono, string correo) {
            return await _context.Clientes
                .FirstOrDefaultAsync(c => c.Telefono == telefono || c.Correo == correo);
        }

        public async Task AgregarCliente(Cliente cliente) {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarCliente(Cliente cliente) {
            var clienteExistente = await _context.Clientes.FindAsync(cliente.IdCliente);

            if (clienteExistente != null) {
                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Telefono = cliente.Telefono;
                clienteExistente.Correo = cliente.Correo;
                clienteExistente.Direccion = cliente.Direccion;

                await _context.SaveChangesAsync();
            }
        }
    }
}