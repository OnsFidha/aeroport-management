using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Domain
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }

        public Plane() { }

        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        } 

        public override string ToString()
        {
            return $"Plane: {PlaneId}, Type: {PlaneType}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate.ToShortDateString()}";
        }
    }
}