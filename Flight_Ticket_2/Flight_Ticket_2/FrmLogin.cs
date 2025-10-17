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
    public partial class FrmLogin : Form
    {
        string connectionString = "Data Source=MINHQUAN\\SQLEXPRESS;Initial Catalog=Flight_Ticket;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (validateInput() && CheckLogin(txtUsername.Text, txtPassword.Text))
            {
                string username = txtUsername.Text.Trim();
                string role = GetUserRole(username);

                FrmMain frmMain = new FrmMain(username, role);
                frmMain.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Users", conn);
                adapter = new SqlDataAdapter(cmd);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool validateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }
        // Check if user input username and password match with any record in database
        private bool CheckLogin(string username, string password)
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                return false;
            }
        }

        private string GetUserRole(string username)
        {
            string role = "";
            try
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = reader["Role"].ToString();
                }
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
            return role;
        }

    }
}
