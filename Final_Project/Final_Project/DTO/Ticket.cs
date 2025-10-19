using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Ticket
    {
        public string ticketID { get; set; }
        public string flightID { get; set; }
        public decimal price { get; set; }
        public string username { get; set; }
        public DateTime bookingDate { get; set; }
        public int quantity { get; set; }
        public decimal totalPrice { get; set; }

    }
}
