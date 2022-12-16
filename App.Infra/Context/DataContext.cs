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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasOne<Rental>(s => s.Rental).WithMany(s => s.Members).HasForeignKey(d => d.RentalId);
            modelBuilder.Entity<MovieRental>().HasKey(s => new {s.MovieId,s.RentalId });
            modelBuilder.Entity<Rental>().Property(s => s.TotalCost).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Movie>().Property(s => s.RentalCost).HasColumnType("decimal(18,2)");


            modelBuilder.Entity<Member>().Navigation(c => c.Rental).AutoInclude();
            modelBuilder.Entity<Rental>().Navigation(c => c.Members).AutoInclude();
            modelBuilder.Entity<Movie>().Navigation(c => c.MovieRentals).AutoInclude();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieRental> MovieRentals  { get; set; }
        public DbSet<Rental> Rentals  { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
