using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.Entites;


namespace Portfolio.Domain.Models.DataContext
{
    public class PortfolioDbContext: DbContext
    {
        public PortfolioDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<AcademicBackground> AcademicBackrounds { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Experience> Experiences { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortfolioDbContext).Assembly);
        }
    }
}
