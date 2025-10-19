using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAL
{
    public class EmailHelper
    {
        private string sendEmail = "nguyenchidung17112005@gmail.com";
        private string appPass = "lcay dwfw srid whkm";

        public void SendTicketEmail(string toEmail, string username, string ticketID, string flightID, string departure, string destination, DateTime date,DateTime datebuy ,string quantity, decimal price, decimal totalprice)
        {
            string subject = $"Flight Ticket - Flight Code {flightID}";

            // Nội dung email
            string body = $@"
                <h2>Nice to meet you {username},</h2>
                <p>Thanks for booking flight tickets at <b>Flight Ticket Saling</b>!</p>
                <table style='border-collapse:collapse'>
                <tr><td><b>Ticket Code:</b></td><td>{ticketID}</td></tr>
                <tr><td><b>Flight Code:</b></td><td>{flightID}</td></tr>
                <tr><td><b>Your journey:</b></td><td>{departure} → {destination}</td></tr>
                <tr><td><b>Departure Date:</b></td><td>{date:dd/MM/yyyy HH:mm}</td></tr>
                <tr><td><b>Booking Date:</b></td><td>{datebuy:dd/MM/yyyy HH:mm}</td></tr>
                <tr><td><b>Price:</b></td><td>{price:N0}</td></tr>
                <tr><td><b>Quantity:</b></td><td>{quantity}</td></tr>
                <tr><td><b>Total Price:</b></td><td>{totalprice:N0} VND</td></tr>
                </table>
                <p>Please be at the airport 60 minutes in advance. ✈️</p>
                <p>Best regards,<br><b>Flight Ticket Saling</b></p>
            ";

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(sendEmail, "Flight Ticket Saling");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true; 

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(sendEmail, appPass);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}
