using Microsoft.EntityFrameworkCore;
using parcial.shared.Entities;

namespace parcial.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options) { }

        public DbSet<proyecto>proyectos { get; set; }
        public DbSet<investigador>Investigadors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<proyecto>().HasIndex(c => c.NombreProyecto).IsUnique();

        }

    }
}
