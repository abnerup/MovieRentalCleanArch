global using Microsoft.EntityFrameworkCore;
using App.Domain.Entities;

namespace App.Infra.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=localhost\\sqlexpress;DataBase=MovieDB;Trusted_Connection=True;TrustServerCertificate=true;",b => b.MigrationsAssembly("Movies.API"));
        }

        public DbSet<Movie> Movies { get; set; }

    }
}
