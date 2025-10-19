using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.BLL
{
    public class FlightBLL : IManager<Flight>
    {
        private DAL.FlightDAL fDAL = new DAL.FlightDAL();
        public DataTable GetAllFlights()
        {
            return fDAL.GetAllFlights();
        }
        public Flight GetFlightByID(string flightID)
        {
            return fDAL.GetFlightByID(flightID);
        }
        public void Add(Flight f)
        {
            if (string.IsNullOrEmpty(f.flightID))
            {
                throw new ArgumentException("Flight ID cannot be empty.");
            }
            if (f.departAirport == f.arriveAirport)
            {
                throw new ArgumentException("Departure and arrival airports cannot be the same.");
            }
            if (f.price <= 0)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
            fDAL.addFLight(f);
        }
        public void Delete(Flight f)
        {
            if (string.IsNullOrEmpty(f.flightID))
            {
                throw new ArgumentException("Flight ID cannot be empty.");
            }
            fDAL.DeleteFlight(f);
        }
        public void UpdateFlight(Flight f)
        {
            if (string.IsNullOrEmpty(f.flightID))
            {
                throw new ArgumentException("Flight ID cannot be empty.");
            }
            if (f.departAirport == f.arriveAirport)
            {
                throw new ArgumentException("Departure and arrival airports cannot be the same.");
            }
            if (f.price <= 0)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
            fDAL.updateFlight(f);
        }
        public DataTable SearchFlight(string dAirport, string aAirport)
        {
            return fDAL.searchFlight(dAirport, aAirport);
        }
    }
}
