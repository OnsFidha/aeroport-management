using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Domain
{
    public class Passenger
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public string TelNumber { get; set; }
        
        public string PassportNumber { get; set; }


        public ICollection<Flight> Flights { get; set; }
        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }

        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == email;
        }

        public bool CheckProfile1(string firstName, string lastName, string email = null)
        {
            if (email == null)
            {
                return CheckProfile(firstName, lastName);
            }
            else
            {
                return CheckProfile(firstName, lastName, email);
            }
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

        public override string ToString()
        {
            return $"Passenger: {FirstName} {LastName}, Email: {EmailAddress}, BirthDate: {BirthDate.ToShortDateString()}";
        }
    }
}
