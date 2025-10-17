using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16_FlyingTicket
{
    internal class Passenger
    {
        private string passengerID;
        private string passengerName;
        private string passportNum;
        private string birthDay;
        private string email;
        private string phone;
        private List<Ticket> tickets;
        public string PassengerID
        {
            get { return passengerID; }
            set { passengerID = value; }
        }
        public string PassengerName
        {
            get { return passengerName; }
            set { passengerName = value; }
        }
        public string PassportNum
        {
            get { return passportNum; }
            set { passportNum = value; }
        }
        public string BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public List<Ticket> Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }

        public Passenger(string passengerID, string passengerName, string passportNum, string birthDay, string email, string phone)
        {
            this.passengerID = passengerID;
            this.passengerName = passengerName;
            this.passportNum = passportNum;
            this.birthDay = birthDay;
            this.email = email;
            this.phone = phone;
            tickets = new List<Ticket>();
        }
        public void PassengerInf()
        {
            Console.WriteLine("PASSENGER");
            Console.WriteLine("Passenger ID: " + passengerID);
            Console.WriteLine("Name: " + passengerName);
            Console.WriteLine("Passport Number: " + passportNum);
            Console.WriteLine("Birth Day: " + birthDay);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Tickets: ");
            foreach (Ticket ticket in tickets)
            {
                ticket.TicketInf();
                Console.WriteLine();
            }
        }
    }
}
