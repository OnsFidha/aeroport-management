using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.applicationCore.Domain;

namespace AM.applicationCore.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public string destination { get; set; }
        public string classe { get; set; }
        public IList<ReservationTicket> Reservations { get; set; }
      
    }
}
