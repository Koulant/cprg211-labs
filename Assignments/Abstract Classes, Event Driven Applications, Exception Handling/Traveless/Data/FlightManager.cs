using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
    internal class FlightManager
    {
        public FlightManager() //Whenever FlightManager is called, it will load list of flights from flights.csv
        {
            LoadListOfFlightsFromFile();
        }

        private const string flightsFile = @"C:\Users\Anton\source\repos\Traveless\Resources\Files\flights.csv";

        public static List<Flight> listOfFlights = new List<Flight>();
        
        //Load list of flights from flights.csv
        public void LoadListOfFlightsFromFile() 
        {
            using (StreamReader cellReader = new StreamReader(flightsFile))
            {
                while (!cellReader.EndOfStream)
                {
                    string line = cellReader.ReadLine();
                    string[] cells = line.Split(',');

                    string flightCode = cells[0];
                    string airline = cells[1];
                    string from = cells[2];
                    string to = cells[3];
                    string day = cells[4];
                    string time = cells[5];
                    int seats = int.Parse(cells[6]);
                    double cost = double.Parse(cells[7]);

                    Flight flights = new Flight(flightCode, airline, from, to, day, time, seats, cost);
                    listOfFlights.Add(flights);
                }
            }
        }

        public static List<Flight> GetFlights() //Returns list of flights
        {
            return listOfFlights;
        }


        //Code from thursday class
        public static List<Flight> FindFlights(string from, string to, string day)
        {

            List<Flight> found = new List<Flight>();

            foreach (Flight flight in listOfFlights)
            {
                if (flight.From == "YYC" & flight.To == "YEG" & flight.Day == "Any")
                {
                    found.Add(flight);
                }
            }
            return found;
        }

        //ASK ALI HOW TO DO THIS?!
        //foreach(Flight flight in flights) //Fill the flights list when button is pressed //Filter from the list in the backend, and refill the list, when button pressed



        //Old list loader
        /*
        public FlightManager()
        {
            populateFlights();
        }

        public void populateFlights()
        {
            Flight flight;

            foreach(string csvLine in System.IO.File.ReadLines(FlightsFile))
            {
                string[] cells = csvLine.Split(",");

                string flightCode = cells[0];
                string airline = cells[1];
                string from = cells[2];
                string to = cells[3];
                string day = cells[4];
                string time = cells[5];
                int seats = int.Parse(cells[6]);
                double cost = double.Parse(cells[7]);

                flight = new Flight(flightCode, airline, from, to, day, time, seats, cost);
                flights.Add(flight);
            }
        }
        */


    }
}
