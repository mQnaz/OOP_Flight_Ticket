using Final_Project.DAL;
using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Final_Project.BLL
{
    public class TicketBLL : IManager<Ticket>
    {
        private TicketDAL tDAL = new TicketDAL();
        public DataTable getTicketsByUsers(string username)
        {
            return tDAL.GetTicketsByUsers(username);
        }
        public void Add(Ticket ticket)
        {
            tDAL.AddTicket(ticket);
        }
        public void DecreaseSeat(string flightID, string ticketID)
        {
            tDAL.ReduceRemainSeat(flightID, ticketID);
        }
        public void Delete(Ticket ticket)
        {
            tDAL.DeleteTicket(ticket);
        }
        public void IncreaseSeat(string flightID, string ticketID)
        {
            tDAL.AddRemainSeat(flightID, ticketID);
        }
        public void ExportPDF(Ticket t, string filePath)
        {
            Document doc = new Document(PageSize.A6);
            PdfWriter.GetInstance(doc, new System.IO.FileStream(filePath, System.IO.FileMode.Create));
            doc.Open(); 

            Paragraph title = new Paragraph("Ticket Information", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);
            doc.Add(new Paragraph("\n"));

            PdfPTable table = new PdfPTable(2);
            table.AddCell("Ticket ID");
            table.AddCell(t.ticketID);
            table.AddCell("Flight ID");
            table.AddCell(t.flightID);
            table.AddCell("Price");
            table.AddCell(t.price.ToString("C"));
            table.AddCell("Username");
            table.AddCell(t.username);
            table.AddCell("Booking Date");
            table.AddCell(t.bookingDate.ToString("g"));
            table.AddCell("Quantity");
            table.AddCell(t.quantity.ToString());
            table.AddCell("Total Price");
            table.AddCell(t.totalPrice.ToString("C"));
            doc.Add(table);

            doc.Add(new Paragraph("Thanks for choosing our service!", new Font(Font.FontFamily.HELVETICA, 12, Font.ITALIC)));

            doc.Close();
        }

    }
}
