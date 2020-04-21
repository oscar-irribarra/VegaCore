using Microsoft.EntityFrameworkCore;
using VegaCore.Models;

namespace VegaCore.Persistence
{
    public class VegaCoreDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

        public VegaCoreDbContext(DbContextOptions<VegaCoreDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(x =>
            new { x.VehicleId, x.FeatureId });
        }
    }
}