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
    public partial class FrmSignup : Form
    {
        string connectionString = "Data Source=MINHQUAN\\SQLEXPRESS;Initial Catalog=Flight_Ticket;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public FrmSignup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (validateInput() && checkExisted(txtUsername.Text) && isPasswordMatch())
            {
                // Insert new user into the database, role default to "Customer"
                conn.Open();
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Role", "Customer");
                cmd.ExecuteNonQuery(); 
                conn.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void FrmSignup_Load(object sender, EventArgs e)
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
        private bool checkExisted(string username)
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Username already exists. Please choose a different username \n" +
                    "Or if you have had another account before, please go back to log in!");
                return false;
            }
            else     
            {
                return true;
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
        private bool isPasswordMatch()
        {
            if (txtPassword.Text != txtCfPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }
            return true;
        }
    }
}
