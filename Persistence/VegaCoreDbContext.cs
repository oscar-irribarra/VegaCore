using Microsoft.EntityFrameworkCore;
using VegaCore.Models;

namespace VegaCore.Persistence{
    public class VegaCoreDbContext : DbContext
    {
        public VegaCoreDbContext(DbContextOptions<VegaCoreDbContext> options)
            :base (options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
    }
}