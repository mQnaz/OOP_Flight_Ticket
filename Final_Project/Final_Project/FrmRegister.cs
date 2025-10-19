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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var uBLL = new BLL.UserBLL();
            
            try
            {
                var user = uBLL.Register(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Registration successful! You can now log in, " + user.Username);
                FrmLogin fLogin = new FrmLogin();
                fLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message);
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
