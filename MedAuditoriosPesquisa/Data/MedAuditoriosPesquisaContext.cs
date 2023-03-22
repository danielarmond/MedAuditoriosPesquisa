using Microsoft.EntityFrameworkCore;
using MedAuditoriosPesquisa.Models;

namespace MedAuditoriosPesquisa.Data
{
    public class MedAuditoriosPesquisaContext : DbContext
    {
        public MedAuditoriosPesquisaContext(DbContextOptions<MedAuditoriosPesquisaContext> options)
           : base(options)
        {
        }

        public DbSet<Local> Local { get; set; }
        
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<StatusPrimario> StatusPrimario { get; set; }

        public DbSet<StatusSecundario> StatusSecundario { get; set; }

        public DbSet<Filial> Filial { get; set; }


    }
}
