using System;
using System.Net.WebSockets;
using AM.applicationCore.Domain;
using AM.applicationCore.Services;

//Plane plane = new Plane(PlaneType.Boeing, 12, DateTime.Now);
//Console.WriteLine(plane.ToString());
////initialisateur 
//Plane p3 = new Plane { Capacity = 50 };
//Console.WriteLine(p3.ToString());
Passenger passenger = new Passenger { LastName = "ons", FirstName = "fidha" };
//Console.WriteLine(passenger.ToString());
//Console.WriteLine(passenger.CheckProfile("elfidha","ons"));
Passenger passenger1 = new Passenger { LastName = "nidhal", FirstName = "arfaoui", EmailAddress = "ni@esprit.tn" };
//Console.WriteLine(passenger1.CheckProfile("arfaoui", "nidhal", "ni@esprit.tn"));
//Console.WriteLine(passenger1.CheckProfile1("arfaoui", "nidhal"));
//Staff staff= new Staff();
//staff.PassengerType();

FlightMethods flightService = new FlightMethods();
flightService.Flights = TestData.listFlights;

//var dates = flightService.GetFlightdates("Paris");
//Console.WriteLine("Flight Dates to Paris:");
//dates.ForEach(date => Console.WriteLine(date));


var date = flightService.GetFlights2("EstimatedDuration", "110");
Console.WriteLine("Flight Dates to Paris by filter:");
date.ForEach(date => Console.WriteLine(date));
Console.WriteLine("******** show flight details******");
flightService.ShowFlightDetails(TestData.BoingPlane);
Console.WriteLine("******** show flight programme number******");

DateTime testDate = new DateTime(2021, 12, 31);
Console.WriteLine(flightService.ProgrammedFlightNumber(testDate));

Console.WriteLine("******** fonction extension******");

passenger.UpperFullName();
Console.WriteLine(passenger.FirstName+' '+passenger.LastName);

passenger1.UpperFullName();
Console.WriteLine(passenger1.FirstName + ' ' + passenger1.LastName);
