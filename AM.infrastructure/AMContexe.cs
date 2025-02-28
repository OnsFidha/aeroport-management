using AM.applicationCore.Domain;
using AM.infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AM.infrastructure
{
    public class AMContext :DbContext 
    {
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
     
        //chaine de cnx 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
            Initial Catalog=AirportManagementDB1;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //1er methode avec class de configuration
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            //2eme methode sans class de configuration
            modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
            modelBuilder.Entity<Plane>().ToTable("myPlanes").Property(p=>p.Capacity).HasColumnName("PlaneCapacity");

            modelBuilder.ApplyConfiguration(new FlightConfiguration());


        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<DateTime>()
                .HaveColumnType("date");
        }

    }
}
