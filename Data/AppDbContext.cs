using Microsoft.EntityFrameworkCore;
using AutoParts.Models;

namespace AutoParts.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        public DbSet<Peca> Pecas { get; set; }
        
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PecaVeiculo>()
                .HasKey(pv => new { pv.PecaId, pv.VeiculoId });
        }
    }
}
