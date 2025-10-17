using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16_FlyingTicket
{
    internal class Ticket
    {
        private string ticketID;
        private Flight flight;
        private decimal price = 1000000;

        public string TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }

        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
            }
        }

        public Ticket(string ticketID, Flight flight)
        {
            this.ticketID = ticketID;
            this.flight = flight;
        }

        public virtual void TicketInf()
        {
            Console.WriteLine("TICKET");
            Console.WriteLine("Ticket ID: " + ticketID);
            Console.WriteLine("Flight ID: " + flight.FlightID);                     
            Console.WriteLine("Departure: " + flight.DepartAirport + " at " + flight.DepartTime);
            Console.WriteLine("Arrival: " + flight.ArriveAirport + " at " + flight.ArriveTime);
            Console.WriteLine("Price: " + price.ToString("C"));
        }
    }
}
