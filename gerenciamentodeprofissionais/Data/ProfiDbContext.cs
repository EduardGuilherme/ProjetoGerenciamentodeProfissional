using gerenciamentodeprofissionais.Data.Map;
using gerenciamentodeprofissionais.Models;
using Microsoft.EntityFrameworkCore;

namespace gerenciamentodeprofissionais.Data
{
    public class ProfiDbContext : DbContext
    {
        public ProfiDbContext(DbContextOptions<ProfiDbContext> options) : base(options) { }

        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new ProfissionalMap());
            modelBuilder.ApplyConfiguration(new EspecialidadeMap());

            modelBuilder.Entity<Especialidade>().HasData(
                new Especialidade { Id = 1, Nome = "Cardiologia", TipoDocumento = "CRM" },
                new Especialidade { Id = 2, Nome = "Nutricionista Clínico", TipoDocumento = "CRN" }
            );

        }
    }
}
