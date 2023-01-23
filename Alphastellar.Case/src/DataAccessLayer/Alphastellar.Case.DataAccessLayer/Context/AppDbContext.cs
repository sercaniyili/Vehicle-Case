using Alphastellar.Case.CoreLayer.Entities;
using Alphastellar.Case.DataAccessLayer.Context.Configirations;
using Alphastellar.Case.DataAccessLayer.Context.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Alphastellar.Case.DataAccessLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new BusConfiguration());
            modelBuilder.ApplyConfiguration(new BoatConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
