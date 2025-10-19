using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    public class Flight
    {
        public string flightID { get; set; }
        public string departAirport { get; set; }
        public DateTime departTime { get; set; }
        public string arriveAirport { get; set; }
        public DateTime arriveTime { get; set; }
        public int remainSeat { get; set; }
        public decimal price { get; set; }
    }
}
