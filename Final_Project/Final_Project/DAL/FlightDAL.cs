using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAL
{
    public class FlightDAL : DbHelper
    {
        // take all flights from database
        public DataTable GetAllFlights()
        {
            string query = "SELECT * FROM Flights";
            return ExecuteQuery(query);
        }
        public Flight GetFlightByID(string flightID)
        {
            string query = "SELECT * FROM Flights WHERE FlightID = @flightID";
            SqlParameter[] prms =
            {
                new SqlParameter("@flightID", flightID)
            };

            DataTable dt = ExecuteQuery(query, prms);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new Flight
                {
                    departAirport = r["DepartAirport"].ToString(),
                    arriveAirport = r["ArriveAirport"].ToString(),
                    departTime = Convert.ToDateTime(r["DepartTime"]),
                };
            }
            return null;
        }

        // add more flights to database
        public int addFLight(Flight f)
        {
            string query = "INSERT INTO Flights (FlightID, DepartAirport, DepartTime, ArriveAirport, ArriveTime, RemainSeat, Price) " +
                           "VALUES (@flightID, @departAirport, @departTime, @arriveAirport, @arriveTime, @remainSeat, @price)";
            SqlParameter[] prms = 
            {
                new SqlParameter("@flightID", f.flightID),
                new SqlParameter("@departAirport", f.departAirport),
                new SqlParameter("@departTime", f.departTime),
                new SqlParameter("@arriveAirport", f.arriveAirport),
                new SqlParameter("@arriveTime", f.arriveTime),
                new SqlParameter("@remainSeat", f.remainSeat),
                new SqlParameter("@price", f.price)
            };
            return ExecuteNonQuery(query, prms);
        }
        // delete flight from database
        public int DeleteFlight(Flight f)
        {
            string query = "DELETE FROM Flights WHERE FlightID = @flightID";
            SqlParameter[] prms =
            {
                new SqlParameter("@flightID", f.flightID)
            };
            return ExecuteNonQuery(query, prms);
        }
        // update flight information in database
        public int updateFlight(Flight f)
        {
            string query = "UPDATE Flights SET DepartAirport = @departAirport, DepartTime = @departTime, " +
                           "ArriveAirport = @arriveAirport, ArriveTime = @arriveTime, RemainSeat = @remainSeat, Price = @price " +
                           "WHERE FlightID = @flightID";
            SqlParameter[] prms =
            {
                new SqlParameter("@flightID", f.flightID),
                new SqlParameter("@departAirport", f.departAirport),
                new SqlParameter("@departTime", f.departTime),
                new SqlParameter("@arriveAirport", f.arriveAirport),
                new SqlParameter("@arriveTime", f.arriveTime),
                new SqlParameter("@remainSeat", f.remainSeat),
                new SqlParameter("@price", f.price)
            };
            return ExecuteNonQuery(query, prms);
        }
        // search flight by depart airport and arrive airport
        public DataTable searchFlight(string departAirport, string arriveAirport)
        {
            string query = "SELECT * FROM Flights WHERE DepartAirport = @departAirport AND ArriveAirport = @arriveAirport";
            SqlParameter[] prms =
            {
                new SqlParameter("@departAirport", departAirport),
                new SqlParameter("@arriveAirport", arriveAirport)
            };
            return ExecuteQuery(query, prms);
        }
    }
}
