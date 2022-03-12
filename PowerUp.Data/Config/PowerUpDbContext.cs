using Microsoft.EntityFrameworkCore;
using PowerUp.Domain.Core.Entidades;

namespace PowerUp.Data.Config
{
    public class PowerUpDbContext : DbContext
    {
        private readonly string _dbConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=PowerUpDB;Trusted_Connection=True;MultipleActiveResultSets=True";
        public DbSet<EstacaoRecarga> EstacoesRecargas { get; set; }

        public PowerUpDbContext()
        {

        }

        public PowerUpDbContext(DbContextOptions<PowerUpDbContext> options) : base(options)
        {

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .Properties<string>()
                .AreUnicode(false)
                .HaveMaxLength(300);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(_dbConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
