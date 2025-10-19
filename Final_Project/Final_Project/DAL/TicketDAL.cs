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
    public class TicketDAL : DbHelper
    {
        // get all tickets with username
        public DataTable GetTicketsByUsers(string username)
        {
            string query = "SELECT * FROM Tickets WHERE Username = @username";
            SqlParameter[] prms =
            {
                new SqlParameter("@username", username)
            };
            return ExecuteQuery(query, prms);
        }
        // get flightID by ticketID
        public int GetFlightIDByTicket(string ticketId)
        {
            string query = "SELECT FlightID FROM Tickets WHERE TicketID = @ticketID";
            SqlParameter[] prms =
            {
                new SqlParameter("@ticketID", ticketId)
            };
            object result = ExecuteScalar(query, prms);
            return result != null ? Convert.ToInt32(result) : -1;
        }
        public int AddTicket(Ticket t)
        {
            string query = "INSERT INTO Tickets (TicketID ,FlightID, Price, Username, BookingDate, Quantity, TotalPrice) " +
                           "VALUES (@ticketID, @flightID, @price, @username, @bookingDate, @quantity, @totalPrice)";
            SqlParameter[] prms =
            {
                new SqlParameter("@ticketID", t.ticketID),
                new SqlParameter("@flightID", t.flightID),
                new SqlParameter("@price", t.price),
                new SqlParameter("@username", t.username),
                new SqlParameter("@bookingDate", t.bookingDate),
                new SqlParameter("@quantity", t.quantity),
                new SqlParameter("@totalPrice", t.totalPrice),
            };
            return ExecuteNonQuery(query, prms);
        }
        public int DeleteTicket(Ticket t)
        {
            string query = "DELETE FROM Tickets WHERE TicketID = @ticketID";

            SqlParameter[] prms =
            {
                new SqlParameter("@ticketID", t.ticketID),
            };
            return ExecuteNonQuery(query, prms);
        }

        public int AddRemainSeat(string flightID, string ticketID)
        {
            string query = @"
                UPDATE Flights
                SET RemainSeat = RemainSeat + 
                    (SELECT Quantity FROM Tickets WHERE TicketID = @ticketID)
                WHERE FlightID = @flightID
            ";

            SqlParameter[] prms =
            {
                new SqlParameter("@flightID", flightID),
                new SqlParameter("@ticketID", ticketID)
            };

            return ExecuteNonQuery(query, prms);
        }
        public int ReduceRemainSeat(string flightID, string ticketID)
        {
            string query = @"
                UPDATE Flights
                SET RemainSeat = RemainSeat - 
                    (SELECT Quantity FROM Tickets WHERE TicketID = @ticketID)
                WHERE FlightID = @flightID
            ";
            SqlParameter[] prms =
            {
                new SqlParameter("@flightID", flightID),
                new SqlParameter("@ticketID", ticketID)
            };

            return ExecuteNonQuery(query, prms);
        }
    }
}
