using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.Entites;
using System.Collections.Generic;

namespace Portfolio.Domain.Models.DataContext
{
    public class PortfolioDbContext: DbContext
    {
        public PortfolioDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Social> Profiles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Portfolia> Portfolias { get; set; }
        public DbSet<Category> Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortfolioDbContext).Assembly);
        }
    }
}
