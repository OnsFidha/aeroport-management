using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.applicationCore.Domain;

namespace AM.applicationCore.Services
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Passenger p)
        {

            p.FirstName = p.FirstName[0].ToString().ToUpper() + p.FirstName.Substring(1);
            p.LastName = p.LastName[0].ToString().ToUpper() + p.LastName.Substring(1);
        }

    }
}
