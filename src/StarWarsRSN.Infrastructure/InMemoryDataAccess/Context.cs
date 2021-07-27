namespace StarWarsRSN.Infrastructure.InMemoryDataAccess
{
    using Microsoft.EntityFrameworkCore;
    //using StarWarsRSN.Domain.Accounts;
    using StarWarsRSN.Domain.Rebeldes;
    using System.Collections.ObjectModel;
    using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;
    using StarWarsRSN.Domain.ReportTraidor;

    public class RSNContext : DbContext
    {
        public Collection<Rebelde> Rebeldes { get; set; }
        public Collection<ReporteTraidor> ReportesTraidores { get; set; }

        public RSNContext()
        {

        }
        public RSNContext(DbContextOptions<RSNContext> options) : base(options)
        {
            Rebeldes = new Collection<Rebelde>();
            ReportesTraidores = new Collection<ReporteTraidor>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rebelde>();
            modelBuilder.Entity<Localizacao>();
            modelBuilder.Entity<Item>();
            modelBuilder.Entity<ReporteTraidor>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
