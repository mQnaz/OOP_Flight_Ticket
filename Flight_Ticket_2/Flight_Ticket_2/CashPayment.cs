using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16_FlyingTicket
{
    internal class CashPayment: Payment
    {
        private string cashierName;
        public string CashierName
        {
            get { return cashierName; }
            set { cashierName = value; }
        }
        public CashPayment(string paymentID, double amount, DateTime paymentDate, string cashierName) : base(paymentID, amount, paymentDate)
        {
            this.cashierName = cashierName;
        }
    }
}
