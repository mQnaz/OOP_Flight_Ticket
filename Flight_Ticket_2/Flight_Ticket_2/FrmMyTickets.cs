using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ticket_2
{
    public partial class FrmMyTickets : Form
    {
        string connectionString = "Data Source=MINHQUAN\\SQLEXPRESS;Initial Catalog=Flight_Ticket;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        private string currentUsername;

        public FrmMyTickets(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void LoadMyTickets()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT t.TicketID, t.FlightID, f.DepartAirport, f.ArriveAirport, 
                                           f.DepartTime, f.ArriveTime, t.Price, t.BookingDate
                                    FROM Tickets t
                                    INNER JOIN Flights f ON t.FlightID = f.FlightID
                                    WHERE t.Username = @Username
                                    ORDER BY t.BookingDate DESC";
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Username", currentUsername);
                    
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    
                    dataGridViewTickets.DataSource = dt;
                    
                    // Format columns
                    if (dataGridViewTickets.Columns.Count > 0)
                    {
                        dataGridViewTickets.Columns["Price"].DefaultCellStyle.Format = "N0";
                        dataGridViewTickets.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMyTickets_Load(object sender, EventArgs e)
        {
            LoadMyTickets();
            lblWelcome.Text = $"Tickets of {currentUsername}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMyTickets();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTickets.CurrentRow == null)
            {
                MessageBox.Show("Please select a ticket to delete.");
                return;
            }

            var ticketId = dataGridViewTickets.CurrentRow.Cells["TicketID"].Value?.ToString();
            var flightId = dataGridViewTickets.CurrentRow.Cells["FlightID"].Value?.ToString();

            if (string.IsNullOrEmpty(ticketId) || string.IsNullOrEmpty(flightId))
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this ticket?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmdDel = new SqlCommand("DELETE FROM Tickets WHERE TicketID=@TicketID AND Username=@Username", conn, tran))
                            {
                                cmdDel.Parameters.AddWithValue("@TicketID", ticketId);
                                cmdDel.Parameters.AddWithValue("@Username", currentUsername);
                                cmdDel.ExecuteNonQuery();
                            }

                            using (SqlCommand cmdSeat = new SqlCommand("UPDATE Flights SET RemainSeat = RemainSeat + 1 WHERE FlightID=@FlightID", conn, tran))
                            {
                                cmdSeat.Parameters.AddWithValue("@FlightID", flightId);
                                cmdSeat.ExecuteNonQuery();
                            }

                            tran.Commit();
                            MessageBox.Show("Ticket deleted.");
                            LoadMyTickets();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Delete failed: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
