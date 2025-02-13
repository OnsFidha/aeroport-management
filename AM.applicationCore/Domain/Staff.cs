using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Domain
{
    public class Staff : Passenger
    {
        public string Function { get; set; }
        public DateTime EmployementDate { get; set; }
        public double Salary { get; set; }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a Staff Member");
        }

        public override string ToString()
        {
            return base.ToString() + $", Function: {Function}, EmploymentDate: {EmployementDate.ToShortDateString()}, Salary: {Salary}";
        }
    }
}
