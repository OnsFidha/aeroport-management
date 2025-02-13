using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string Nationality { get; set; }
        public string HealthInformation { get; set; }

        // Polymorphism by Inheritance
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a Traveller");
        }

        public override string ToString()
        {
            return base.ToString() + $", Nationality: {Nationality}";
        }
    }
}
