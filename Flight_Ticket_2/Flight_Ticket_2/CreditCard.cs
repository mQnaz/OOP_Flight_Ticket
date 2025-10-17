using System;

namespace Group16_FlyingTicket
{
    internal class CreditCard : Payment
    {
        private string cardNumber;
        private string cardHolderName;
        private DateTime expiryDate;
        private string cvv;

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public string CardHolderName
        {
            get { return cardHolderName; }
            set { cardHolderName = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        public string CVV
        {
            get { return cvv; }
            set { cvv = value; }
        }

        // Constructor kế thừa từ Payment + thuộc tính riêng của CreditCard
        public CreditCard(string paymentID, double amount, DateTime paymentDate,
                          string cardNumber, string cardHolderName,
                          DateTime expiryDate, string cvv)
            : base(paymentID, amount, paymentDate) // Gọi constructor của Payment
        {
            this.cardNumber = cardNumber;
            this.cardHolderName = cardHolderName;
            this.expiryDate = expiryDate;
            this.cvv = cvv;
        }

        // Method: Xử lý thanh toán (giả lập)
        public void ProcessPayment()
        {
            Console.WriteLine($"Thanh toán {Amount} VNĐ bằng thẻ {CardNumber} - Chủ thẻ: {CardHolderName}");
        }
    }
}
