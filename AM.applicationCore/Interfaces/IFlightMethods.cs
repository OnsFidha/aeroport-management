using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.applicationCore.Domain;

namespace AM.applicationCore.Interfaces
{
    public interface IFlightMethods
    {
        List<Flight> GetFlights2(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        public IEnumerable<DateTime> GetFlightdates(string destination);
        public double DurationAverage(string destination);
        public IEnumerable<Flight> OrderedDurationFlights();
        public IEnumerable<Traveller> SeniorTravellers(Flight flight);
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
        public void DestinationGroupedF();
        void GetFlights(string filterType, string filterValue);
    }
}
