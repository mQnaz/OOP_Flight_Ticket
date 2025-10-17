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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Flight_Ticket_2
{
    public partial class FrmMain : Form
    {
        string connectionString = "Data Source=MINHQUAN\\SQLEXPRESS;Initial Catalog=Flight_Ticket;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        private string currentUsername;
        private string currentRole;
        public FrmMain(string username, string role)
        {
            InitializeComponent();
            currentUsername = username;
            currentRole = role;
        }
        private void LoadFlightData()
        {
            try
            {
                dt.Clear(); // xóa dữ liệu cũ trong DataTable
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Flights";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    
                    // Make all columns fill the DataGridView width
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flight data: " + ex.Message);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadFlightData();

            // Only admins can delete/add flights
            if (btnDeleteFlight != null && btnAddFlight != null)
            {
                bool isAdmin = string.Equals(currentRole, "Admin", StringComparison.OrdinalIgnoreCase);
                btnDeleteFlight.Visible = isAdmin;
                btnDeleteFlight.Enabled = isAdmin;
                btnAddFlight.Visible = isAdmin;
                btnAddFlight.Enabled = isAdmin;
                
                // Make textboxes editable for admins to add new flights
                if (isAdmin)
                {
                    txtFlightID.ReadOnly = false;
                    txtDepart.ReadOnly = false;
                    txtArrive.ReadOnly = false;
                    txtDepartTime.ReadOnly = false;
                    txtArriveTime.ReadOnly = false;
                    txtSeat.ReadOnly = false;
                    txtPrice.ReadOnly = false;
                    
                    // Clear textboxes for new flight input
                    ClearFlightInputs();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtFlightID.Text = row.Cells["FlightID"]?.Value?.ToString() ?? string.Empty;
                txtDepart.Text = row.Cells["DepartAirport"]?.Value?.ToString() ?? string.Empty;
                txtArrive.Text = row.Cells["ArriveAirport"]?.Value?.ToString() ?? string.Empty;
                txtDepartTime.Text = row.Cells["DepartTime"]?.Value?.ToString() ?? string.Empty;
                txtArriveTime.Text = row.Cells["ArriveTime"]?.Value?.ToString() ?? string.Empty;
                txtSeat.Text = row.Cells["RemainSeat"]?.Value?.ToString() ?? string.Empty;

                var priceObj = row.Cells["Price"]?.Value;
                if (priceObj != null && priceObj != DBNull.Value && decimal.TryParse(priceObj.ToString(), out var priceVal))
                {
                    txtPrice.Text = priceVal.ToString("N0") + " VND";
                }
                else
                {
                    txtPrice.Text = string.Empty;
                }
            }
        }

     
        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {

                string flightID = txtFlightID.Text.Trim();
                string username = currentUsername; 
                DateTime bookingDate = DateTime.Now;


                decimal price = decimal.Parse(txtPrice.Text.Replace(" VND", "").Replace(",", "").Trim());


                if (string.IsNullOrEmpty(flightID))
                {
                    MessageBox.Show("Please select your flight before booking!", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("User not identified. Please log in again!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int remainSeat = int.Parse(txtSeat.Text);
                if (remainSeat <= 0)
                {
                    MessageBox.Show("This flight is fully booked!", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string insertTicketQuery = "INSERT INTO Tickets (TicketID, FlightID, Username, BookingDate, Price) VALUES (@TicketID, @FlightID, @Username, @BookingDate, @Price)";
                string updateSeatQuery = "UPDATE Flights SET RemainSeat = RemainSeat - 1 WHERE FlightID = @FlightID";

                using (SqlConnection conn = new SqlConnection("Data Source=MINHQUAN\\SQLEXPRESS;Initial Catalog=Flight_Ticket;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"))
                {
                    conn.Open();

                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {

                            using (SqlCommand cmdInsert = new SqlCommand(insertTicketQuery, conn, tran))
                            {
                                string ticketID = Guid.NewGuid().ToString().Substring(0, 8);
                                cmdInsert.Parameters.AddWithValue("@TicketID", ticketID);
                                cmdInsert.Parameters.AddWithValue("@FlightID", flightID);
                                cmdInsert.Parameters.AddWithValue("@Username", username);
                                cmdInsert.Parameters.AddWithValue("@BookingDate", bookingDate);
                                cmdInsert.Parameters.AddWithValue("@Price", price);
                                cmdInsert.ExecuteNonQuery();
                            }


                            using (SqlCommand cmdUpdate = new SqlCommand(updateSeatQuery, conn, tran))
                            {
                                cmdUpdate.Parameters.AddWithValue("@FlightID", flightID);
                                cmdUpdate.ExecuteNonQuery();
                            }

                            tran.Commit();
                            MessageBox.Show("Booking Successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            using (var myTickets = new FrmMyTickets(currentUsername))
                            {
                                myTickets.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Error Booking: " + ex.Message);
                        }
                    }
                }

                LoadFlightData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            FrmMyTickets myTicketsForm = new FrmMyTickets(currentUsername);
            myTicketsForm.ShowDialog();
        }

        private void BookTicket(string flightID, decimal price)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string ticketID = Guid.NewGuid().ToString().Substring(0, 8); // Tạo ID ngẫu nhiên
                string query = @"INSERT INTO Tickets (TicketID, FlightID, Price, Username, BookingDate)
                         VALUES (@TicketID, @FlightID, @Price, @Username, @BookingDate)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TicketID", ticketID);
                cmd.Parameters.AddWithValue("@FlightID", flightID);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Username", currentUsername);
                cmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Ticket booked successfully!", "Success");
            }
        }

        private void pnlTicketDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearFlightInputs()
        {
            txtFlightID.Text = "";
            txtDepart.Text = "";
            txtArrive.Text = "";
            txtDepartTime.Text = "";
            txtArriveTime.Text = "";
            txtSeat.Text = "";
            txtPrice.Text = "";
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (!string.Equals(currentRole, "Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only admins can add flights.");
                return;
            }

            // Get data from textboxes
            string flightID = txtFlightID.Text.Trim();
            string departAirport = txtDepart.Text.Trim();
            string arriveAirport = txtArrive.Text.Trim();
            string departTimeStr = txtDepartTime.Text.Trim();
            string arriveTimeStr = txtArriveTime.Text.Trim();
            string seatStr = txtSeat.Text.Trim();
            string priceStr = txtPrice.Text.Replace(" VND", "").Replace(",", "").Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(flightID) || string.IsNullOrEmpty(departAirport) || 
                string.IsNullOrEmpty(arriveAirport) || string.IsNullOrEmpty(departTimeStr) || 
                string.IsNullOrEmpty(arriveTimeStr) || string.IsNullOrEmpty(seatStr) || 
                string.IsNullOrEmpty(priceStr))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                DateTime departTime = DateTime.Parse(departTimeStr);
                DateTime arriveTime = DateTime.Parse(arriveTimeStr);
                int totalSeats = int.Parse(seatStr);
                decimal price = decimal.Parse(priceStr);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Flights (FlightID, DepartAirport, ArriveAirport, DepartTime, ArriveTime, RemainSeat, Price) 
                                   VALUES (@FlightID, @DepartAirport, @ArriveAirport, @DepartTime, @ArriveTime, @RemainSeat, @Price)";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FlightID", flightID);
                        cmd.Parameters.AddWithValue("@DepartAirport", departAirport);
                        cmd.Parameters.AddWithValue("@ArriveAirport", arriveAirport);
                        cmd.Parameters.AddWithValue("@DepartTime", departTime);
                        cmd.Parameters.AddWithValue("@ArriveTime", arriveTime);
                        cmd.Parameters.AddWithValue("@RemainSeat", totalSeats);
                        cmd.Parameters.AddWithValue("@Price", price);
                        
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Flight added successfully!");
                LoadFlightData(); // Refresh the grid
                ClearFlightInputs(); // Clear for next input
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding flight: " + ex.Message);
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (!string.Equals(currentRole, "Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only admins can delete flights.");
                return;
            }

            var flightID = txtFlightID.Text.Trim();
            if (string.IsNullOrEmpty(flightID))
            {
                MessageBox.Show("Please select a flight to delete.");
                return;
            }

            var confirm = MessageBox.Show($"Delete flight {flightID}? All related tickets will be removed.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                            using (var cmdDelTickets = new SqlCommand("DELETE FROM Tickets WHERE FlightID=@FlightID", conn, tran))
                            {
                                cmdDelTickets.Parameters.AddWithValue("@FlightID", flightID);
                                cmdDelTickets.ExecuteNonQuery();
                            }

                            using (var cmdDelFlight = new SqlCommand("DELETE FROM Flights WHERE FlightID=@FlightID", conn, tran))
                            {
                                cmdDelFlight.Parameters.AddWithValue("@FlightID", flightID);
                                cmdDelFlight.ExecuteNonQuery();
                            }

                            tran.Commit();
                            MessageBox.Show("Flight deleted.");
                            LoadFlightData();
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
    }
}
