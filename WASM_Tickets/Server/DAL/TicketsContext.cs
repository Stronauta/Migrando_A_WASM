using Microsoft.EntityFrameworkCore;
using WASM_Tickets.Shared;

namespace WASM_Tickets.Server.DAL
{
    public class TicketsContext : DbContext
    {
        public TicketsContext(DbContextOptions<TicketsContext> options) : base(options)
        {

        }
        public DbSet<Tickets> Tickets { get; set; }

    }
}
