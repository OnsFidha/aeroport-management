using AM.applicationCore.Domain;
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
            Initial Catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);

        }

    }
}
