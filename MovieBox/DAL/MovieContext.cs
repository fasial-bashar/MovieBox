using MovieBox.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MovieBox.DAL
{
    public class MovieContext : DbContext
    {

        public MovieContext() : base("MovieContext")
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ComingSoon> ComingSoon { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}