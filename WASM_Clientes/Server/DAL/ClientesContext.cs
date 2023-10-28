using Microsoft.EntityFrameworkCore;
using WASM_Clientes.Shared;

namespace WASM_Clientes.Server.DAL   
{
    public class ClientesContext : DbContext
    {
        public ClientesContext(DbContextOptions<ClientesContext> options) : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
    }
}
