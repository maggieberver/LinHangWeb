using Segunda4F.Data;

namespace Segunda4F.Repositorios {
    public interface IRepositorioClientes {
        Task<List<Cliente>> ObtenerClientes();
        Task<Cliente?> ObtenerClientePorId(int id);
        Task<Cliente?> ObtenerClientePorTelefonoOCorreo(string telefono, string correo);
        Task AgregarCliente(Cliente cliente);
        Task ActualizarCliente(Cliente cliente);
    }
}