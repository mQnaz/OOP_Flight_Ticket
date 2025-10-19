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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var uBLL = new BLL.UserBLL();
                var user = uBLL.Login(txtUsername.Text, txtPassword.Text);
                Session.CurrentUsername = txtUsername.Text;
                Session.CurrentUserRole = user.Role;
                MessageBox.Show("Login successful! Welcome " + user.Username);
                if (user.Role == "Admin")
                {
                    FrmAdmin fAdmin = new FrmAdmin();
                    fAdmin.Show();
                    this.Hide();   
                }
                else
                {
                    FrmUser fUser = new FrmUser();
                    fUser.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
