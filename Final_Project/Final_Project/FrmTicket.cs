using Final_Project.BLL;
using Final_Project.DAL;
using Final_Project.DTO;
using iTextSharp.text.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FrmTicket : Form
    {
        private TicketBLL tBLL = new TicketBLL();
        private FlightBLL fBLL = new FlightBLL();
        
        public FrmTicket()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadTickets();
        }
        private void LoadTickets()
        {
            string username = Session.CurrentUsername;
            dataGridViewTickets.DataSource = new TicketBLL().getTicketsByUsers(username);
        }

        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUserRole == "Admin")
            {
                FrmAdmin fAdmin = new FrmAdmin();
                fAdmin.Show();
                this.Hide();
            }
            else if (Session.CurrentUserRole == "Customer")
            {
                FrmUser fUser = new FrmUser();
                fUser.Show();
                this.Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewTickets.SelectedRows[0];
                string ticketID = row.Cells["TicketID"].Value.ToString();
                string flightID = row.Cells["FlightID"].Value.ToString();
                var t = new Ticket
                {
                    ticketID = ticketID,
                    flightID = flightID,
                };
                tBLL.IncreaseSeat(flightID, ticketID);
                tBLL.Delete(t);
                MessageBox.Show("Ticket cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please select a ticket to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridViewTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewTickets.SelectedRows[0];
                var t = new Ticket
                {
                    ticketID = row.Cells["TicketID"].Value.ToString(),
                    flightID = row.Cells["FlightID"].Value.ToString(),
                    price = Convert.ToDecimal(row.Cells["Price"].Value),
                    username = row.Cells["Username"].Value.ToString(),
                    bookingDate = Convert.ToDateTime(row.Cells["BookingDate"].Value),
                    quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    totalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value)
                };

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF file |*.pdf",
                    Title = "Save Ticket as PDF",
                    FileName = $"Ticket_{t.ticketID}.pdf"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tBLL.ExportPDF(t, saveFileDialog.FileName);
                    MessageBox.Show("Ticket exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Please choose ticket to export to PDF File ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            
            try
            { 
                DataGridViewRow row = dataGridViewTickets.SelectedRows[0];
                var t = new Ticket
                {
                    ticketID = row.Cells["TicketID"].Value.ToString(),
                    flightID = row.Cells["FlightID"].Value.ToString(),
                    price = Convert.ToDecimal(row.Cells["Price"].Value),
                    username = row.Cells["Username"].Value.ToString(),
                    bookingDate = Convert.ToDateTime(row.Cells["BookingDate"].Value),
                    quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    totalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value)
                };
                FlightBLL fBLL = new FlightBLL();
                Flight flight = fBLL.GetFlightByID(t.flightID);
                EmailHelper emailHelper = new EmailHelper();
                string pdfPath = $"Ticket_{t.ticketID}.pdf";
                emailHelper.SendTicketEmail(
                    toEmail: txtEmail.Text,
                    username: t.username,
                    ticketID: t.ticketID,
                    flightID: t.flightID,
                    departure: flight.departAirport,
                    destination: flight.arriveAirport,
                    date: flight.departTime,
                    datebuy: t.bookingDate,
                    price:  t.price,
                    quantity: t.quantity.ToString(),
                    totalprice: t.totalPrice
                    
                );
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);       

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email" + ex.Message);
            }
        }
    }
}
