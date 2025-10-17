using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16_FlyingTicket
{
    internal class Economy: Ticket
    {
        private string seatClass = "Economy";
        private int percentPriceReduce = 20;
        public Economy(string ticketID, Flight flight) : base(ticketID, flight)
        {
            seatClass = "Economy";
            percentPriceReduce = 20;
        }
        public override void TicketInf()
        {
            base.TicketInf();
            Console.WriteLine("Seat Class: " + seatClass);
            Console.WriteLine("Final Price: " + GetFinalPrice().ToString("C"));
        }
        public decimal GetFinalPrice()
        {
            return Price - Price * percentPriceReduce / 100;
        }
        public void SetSeatClass(string newClass)
        {
            seatClass = newClass;
        }
    }
}
