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

namespace Final_Project
{
    public partial class FrmUser : Form
    {
        private TicketBLL tBLL= new TicketBLL();
        private FlightBLL fBLL= new FlightBLL();
        private Random random = new Random();
        public FrmUser()
        {
            InitializeComponent();
        }
        private void LoadFlights()
        {
            dgvFlights.DataSource = new BLL.FlightBLL().GetAllFlights();
        }
        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadFlights();
        }
        private string GenerateTicketID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void ResetForm()
        {
            txtFlightID.Clear();
            txtDepart.Clear();
            txtArrive.Clear();
            txtSeat.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtDepartTime.Clear();
            txtArriveTime.Clear();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadFlights();
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
                tBLL.Add(t);
                tBLL.DecreaseSeat(t.flightID, t.ticketID);
                MessageBox.Show("Flight booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
                LoadFlights();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            FrmTicket fTicket = new FrmTicket();
            fTicket.Show();
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
            if ((txtDepart.Text != "TPHCM" && txtDepart.Text != "HN" && txtDepart.Text != "DN" && txtDepart.Text != "HP")
                || (txtArrive.Text != "TPHCM" && txtArrive.Text != "HN" && txtArrive.Text != "DN" && txtArrive.Text != "HP")
                )
            {
                MessageBox.Show("Please read the note above", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (depart == arrive)
            {
                MessageBox.Show("Departure and arrival airports cannot be the same.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dgvFlights.DataSource = fBLL.SearchFlight(depart, arrive);
                MessageBox.Show("Search completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching flights: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
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
                    txtDepartTime.Text = Convert.ToString(row.Cells["departTime"].Value);
                    txtArrive.Text = row.Cells["arriveAirport"].Value.ToString();
                    txtArriveTime.Text = Convert.ToString(row.Cells["arriveTime"].Value);
                    txtSeat.Text = row.Cells["remainSeat"].Value.ToString();
                    txtPrice.Text = row.Cells["price"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
