﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore.Domain
{
    public class Passenger
    {

        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "doit etre min 3"), MaxLength(25, ErrorMessage = "doit etre max 25")]
        public string FirstName { get; set; }


        public string LastName { get; set; }


        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string EmailAddress { get; set; }


        [DataType(DataType.Date, ErrorMessage = "ajouter  valid date.")]
        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }


        [RegularExpression(@"^\d{8}$", ErrorMessage = "Phone Number doit etre 8 chiffres.")]
        public int TelNumber { get; set; }
        [Key]
        [StringLength(7)]
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
