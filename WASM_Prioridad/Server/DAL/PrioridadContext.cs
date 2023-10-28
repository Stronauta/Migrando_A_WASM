using Microsoft.EntityFrameworkCore;
using WASM_Prioridad.Shared;

namespace WASM_Prioridad.Server.DAL
{
    public class PrioridadContext : DbContext
    {
        public PrioridadContext(DbContextOptions<PrioridadContext> options) : base(options)
        {
        }
        public DbSet<Prioridad> Prioridades { get; set; }
    }
}
