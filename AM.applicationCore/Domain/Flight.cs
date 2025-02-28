using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Domain
{
    public class Flight
    {

        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string airline_logo { get; set; }

        public Plane Plane { get; set; }
        [ForeignKey("Plane")]
        public int PlaneFK { get; set; }
   

        public  ICollection<Passenger> Passengers { get; set; }

        public override string ToString()
        {
            return $"Flight: {FlightId}, Date: {FlightDate.ToShortDateString()}, Duration: {EstimatedDuration}, Departure: {Departure}, Destination: {Destination}";
        }
    }
}
