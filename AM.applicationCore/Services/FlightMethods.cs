using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.applicationCore.Domain;
using AM.applicationCore.Interfaces;

namespace AM.applicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    flightDates.Add(Flights[i].FlightDate);
                }
            }
            return flightDates;
        }
        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            List<Flight> filteredFlights = new List<Flight>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (
                    (filterType == "Destination" && Flights[i].Destination == filterValue) ||
                    (filterType == "Departure" && Flights[i].Departure == filterValue) ||
                    (filterType == "FlightDate" && Flights[i].FlightDate.ToString("yyyy-MM-dd") == filterValue) ||
                    (filterType == "EstimatedDuration" && Flights[i].EstimatedDuration.ToString() == filterValue) ||
                    (filterType == "EffectiveArrival" && Flights[i].EffectiveArrival.ToString("yyyy-MM-dd HH:mm:ss") == filterValue)
                    )
                {
                    filteredFlights.Add(Flights[i]);
                }
            }
            return filteredFlights;
        }

    }
}
