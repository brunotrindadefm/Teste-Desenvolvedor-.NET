using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Inscricao> Inscricao { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<ProcessoSeletivo> ProcessosSeletivos { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscricao>(entity =>
            {
                entity.HasOne(i => i.Lead)
                      .WithMany(l => l.Inscricoes)
                      .HasForeignKey(i => i.LeadId);

                entity.HasOne(i => i.ProcessoSeletivo)
                      .WithMany(p => p.Inscricoes)
                      .HasForeignKey(i => i.ProcessoSeletivoId);

                entity.HasOne(i => i.Oferta)
                      .WithMany(o => o.Inscricoes)
                      .HasForeignKey(i => i.OfertaId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
