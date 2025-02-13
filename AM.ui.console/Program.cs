using System;
using System.Net.WebSockets;
using AM.applicationCore.Domain;
using AM.applicationCore.Services;

//Plane plane = new Plane(PlaneType.Boeing, 12, DateTime.Now);
//Console.WriteLine(plane.ToString());
////initialisateur 
//Plane p3 = new Plane { Capacity = 50 };
//Console.WriteLine(p3.ToString());
//Passenger passenger = new Passenger { LastName = "ons", FirstName = "fidha" };
//Console.WriteLine(passenger.ToString());
//Console.WriteLine(passenger.CheckProfile("elfidha","ons"));
//Passenger passenger1 = new Passenger { LastName = "nidhal", FirstName = "arfaoui" ,EmailAddress="ni@esprit.tn"};
//Console.WriteLine(passenger1.CheckProfile("arfaoui", "nidhal", "ni@esprit.tn"));
//Console.WriteLine(passenger1.CheckProfile1("arfaoui", "nidhal"));
//Staff staff= new Staff();
//staff.PassengerType();

FlightMethods flightService = new FlightMethods();
flightService.Flights = TestData.listFlights;

var dates = flightService.GetFlightDates("Paris");
Console.WriteLine("Flight Dates to Paris:");
dates.ForEach(date => Console.WriteLine(date));


var date = flightService.GetFlights("EstimatedDuration", "110");
Console.WriteLine("Flight Dates to Paris by filter:");
date.ForEach(date => Console.WriteLine(date));




