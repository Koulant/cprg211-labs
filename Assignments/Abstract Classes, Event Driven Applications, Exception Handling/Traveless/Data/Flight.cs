using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
    internal class Flight
    {
        //private string flightCode;
        //private string airline;
        //private string from;
        //private string to;
        //private string day;
        //private string time;
        //private int seats;
        //private double cost;

        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string From { get; set ; }
        public string To { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public int Seats { get; set; }
        public double Cost { get; set; }



        public Flight() { }

        public Flight(string flightCode, string airline, string from, string to, string day, string time, int seats, double cost)
        {
            FlightCode = flightCode;
            Airline = airline;
            From = from;
            To = to;
            Day = day;
            Time = time;
            Seats = seats;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{FlightCode}, {Airline}, {From}, {To}, {Day}, {Time}, {Seats} Seats, ${Cost}";
        }
    }
}
