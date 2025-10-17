using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16_FlyingTicket
{
    internal class Business: Ticket
    {
        private string seatClass = "Business";
        private int percentPriceAdd = 50;

        public Business(string ticketID, Flight flight) : base(ticketID, flight)
        {
            seatClass = "Business";
            percentPriceAdd = 50;
        }

        public override void TicketInf()
        {
            base.TicketInf();
            Console.WriteLine("Seat Class: " + seatClass);
            Console.WriteLine("Final Price: " + GetFinalPrice().ToString("C"));
        }

        public decimal GetFinalPrice()
        {
            return Price + Price * percentPriceAdd / 100;
        }

        public void SetSeatClass(string newClass)
        {
            seatClass = newClass;
        }

    }
}
