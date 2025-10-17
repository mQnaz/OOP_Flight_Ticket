using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16_FlyingTicket
{
    internal class Flight
    {
        private string flightID;
        private string departAirport;
        private DateTime departTime;
        private string arriveAirport;
        private DateTime arriveTime;
        private int remainSeat;

        
        public string FlightID
        {
            get { return flightID; }
            set { flightID = value; }
        }

        public string DepartAirport
        {
            get { return departAirport; }
            set { departAirport = value; }
        }

        public DateTime DepartTime
        {
            get { return departTime; }
            set { departTime = value; }
        }

        public string ArriveAirport
        {
            get { return arriveAirport; }
            set { arriveAirport = value; }
        }

        public DateTime ArriveTime
        {
            get { return arriveTime; }
            set { arriveTime = value; }
        }

        public int RemainSeat
        {
            get { return remainSeat; }
            set
            {
                if (value >= 0)
                    remainSeat = value;
            }
        }

        public Flight(string flightID, string departAirport, DateTime departTime, string arriveAirport, DateTime arriveTime, int remainSeat)
        {
            this.FlightID = flightID;
            this.DepartAirport = departAirport;
            this.DepartTime = departTime;
            this.ArriveAirport = arriveAirport;
            this.ArriveTime = arriveTime;
            this.RemainSeat = remainSeat;
        }


        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Flight ID: {FlightID}");
            Console.WriteLine($"From: {DepartAirport} at {DepartTime}");
            Console.WriteLine($"To: {ArriveAirport} at {ArriveTime}");
            Console.WriteLine($"Seats Remaining: {RemainSeat}");
        }
    }
}
