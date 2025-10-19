using Final_Project.BLL;
using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Final_Project
{
    public partial class FrmAdmin : Form
    {
        private FlightBLL fBll= new FlightBLL();
        private TicketBLL tBll= new TicketBLL();
        private Random random = new Random();  
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            LoadFlights();
        }
        private void LoadFlights()
        {
            dgvFlights.DataSource = new BLL.FlightBLL().GetAllFlights();
        }
        private void ResetForm()
        {
            txtFlightID.Clear();
            txtDepart.Clear();
            txtArrive.Clear();
            txtSeat.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            dtpDepart.Value = DateTime.Now;
            dtpArrive.Value = DateTime.Now;
        }
        private string GenerateTicketID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            try
            {
                var f = new Flight
                {
                    flightID = txtFlightID.Text,
                    departAirport = txtDepart.Text,
                    departTime = dtpDepart.Value,
                    arriveAirport = txtArrive.Text,
                    arriveTime = dtpArrive.Value,
                    remainSeat = Convert.ToInt32(txtSeat.Text),
                    price = Convert.ToDecimal(txtPrice.Text)
                };
                fBll.Add(f);
                MessageBox.Show("Flight added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                LoadFlights();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding flight: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            try
            {
                var f = new Flight
                {
                    flightID = txtFlightID.Text
                };
                fBll.Delete(f);
                MessageBox.Show("Flight deleted successfully!");
                ResetForm();
                LoadFlights();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting flight: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var f = new Flight
                {
                    flightID = txtFlightID.Text,
                    departAirport = txtDepart.Text,
                    departTime = dtpDepart.Value,
                    arriveAirport = txtArrive.Text,
                    arriveTime = dtpArrive.Value,
                    remainSeat = Convert.ToInt32(txtSeat.Text),
                    price = Convert.ToDecimal(txtPrice.Text)
                };
                fBll.UpdateFlight(f);
                MessageBox.Show("Flight updated successfully!");
                ResetForm();
                LoadFlights();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating flight: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFlights_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvFlights.Rows[e.RowIndex];
                    txtFlightID.Text = row.Cells["flightID"].Value.ToString();
                    txtDepart.Text = row.Cells["departAirport"].Value.ToString();
                    dtpDepart.Value = Convert.ToDateTime(row.Cells["departTime"].Value);
                    txtArrive.Text = row.Cells["arriveAirport"].Value.ToString();
                    dtpArrive.Value = Convert.ToDateTime(row.Cells["arriveTime"].Value);
                    txtSeat.Text = row.Cells["remainSeat"].Value.ToString();
                    txtPrice.Text = row.Cells["price"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string depart = txtDepart.Text.Trim();
            string arrive = txtArrive.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtDepart.Text) || string.IsNullOrWhiteSpace(txtArrive.Text))
            {
                MessageBox.Show("Please input your departure place and destination", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if ((txtDepart.Text != "TPHCM" && txtDepart.Text!="HN" && txtDepart.Text!="DN" && txtDepart.Text!="HP")
                || (txtArrive.Text != "TPHCM" && txtArrive.Text != "HN" && txtArrive.Text != "DN" && txtArrive.Text != "HP")
                )
            {
                MessageBox.Show("Please read the note above","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (depart == arrive)
            {
                MessageBox.Show("Departure and arrival airports cannot be the same.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                dgvFlights.DataSource = fBll.SearchFlight(depart, arrive);
                MessageBox.Show("Search completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching flights: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            FrmTicket fTicket = new FrmTicket();
            fTicket.Show();
            this.Hide();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

            try
            {
                var t = new Ticket
                {
                    ticketID = GenerateTicketID(),
                    flightID = txtFlightID.Text,
                    price = Convert.ToDecimal(txtPrice.Text),
                    username = Session.CurrentUsername,
                    bookingDate = DateTime.Now,
                    quantity = Convert.ToInt32(txtQuantity.Text),
                    totalPrice = Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQuantity.Text)
                };
                tBll.Add(t);
                tBll.DecreaseSeat (t.flightID, t.ticketID);
                MessageBox.Show("Flight booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                LoadFlights();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error booking flight:\n" +
                    ex.Message + "\n\n" +
                    "Source: " + ex.Source + "\n" +
                    "StackTrace:\n" + ex.StackTrace
                );
            }
        }
    }
}
