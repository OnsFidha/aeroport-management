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
        List<Flight> GetFlights(string filterType, string filterValue);
    }
}
