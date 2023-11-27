using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftwareEngineering
{
    public partial class Homepage : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE;Network Library=dbmssocn;Initial Catalog=VendorApplication;Integrated Security=True";


        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isUserSelected = false;
        private void radioButtonUSER_CheckedChanged(object sender, EventArgs e)
        {
            isUserSelected = true;
        }

        private bool isAdminSelected = false;
        private void radioButtonADMIN_CheckedChanged(object sender, EventArgs e)
        {
            isAdminSelected = true;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //to show re-direction to login page
            if (radioButtonUSER.Checked)
            {
                // The user selected "User" and clicked "Login"
                UserLoginForm userLoginForm = new UserLoginForm();
                userLoginForm.Show();
                this.Hide();
            }
            else if (radioButtonADMIN.Checked)
            {
                // The user selected "Admin" and clicked "Login"
                AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
                this.Hide();
            }


        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            //to show re-direction to Register page
            if (radioButtonUSER.Checked)
            {
                // The user selected "User" and clicked "Register"
                UserRegistrationForm userRegistrationForm = new UserRegistrationForm();
                userRegistrationForm.Show();
                this.Hide();
            }
            else if (radioButtonADMIN.Checked)
            {
                // The user selected "Admin" and clicked "Register"
                AdminRegistrationForm adminRegistrationForm = new AdminRegistrationForm();
                adminRegistrationForm.Show();
                this.Hide();
            }


        }
    }
}
