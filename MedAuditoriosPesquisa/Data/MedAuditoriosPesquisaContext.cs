using Microsoft.EntityFrameworkCore;
using MedAuditoriosPesquisa.Models;
using MedAuditoriosPesquisa.Mappings;

namespace MedAuditoriosPesquisa.Data
{
    public class MedAuditoriosPesquisaContext : DbContext
    {
        public MedAuditoriosPesquisaContext(DbContextOptions<MedAuditoriosPesquisaContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new StatusPrimarioMap());
            modelBuilder.ApplyConfiguration(new StatusSecundarioMap());
            modelBuilder.ApplyConfiguration(new FilialMap());
            modelBuilder.ApplyConfiguration(new LocalMap());

        }

        public DbSet<Local> Local { get; set; }
        
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<StatusPrimario> StatusPrimario { get; set; }

        public DbSet<StatusSecundario> StatusSecundario { get; set; }

        public DbSet<Filial> Filial { get; set; }


    }
}
