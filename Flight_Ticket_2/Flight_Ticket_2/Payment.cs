using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16_FlyingTicket
{
    internal class Payment
    {
        private string paymentID;
        private double amount;
        private DateTime paymentDate;

        public string PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
        public Payment(string paymentID, double amount, DateTime paymentDate)
        {
            this.paymentID = paymentID;
            this.amount = amount;
            this.paymentDate = paymentDate;
        }
    }
}
