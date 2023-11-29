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
    public partial class UserRegistrationForm : Form
    {
        
        private readonly UserRegistrationBackend backend;
        private bool isUserRegistered = false; // Flag to track user registration status
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";


        public UserRegistrationForm()
        {
            InitializeComponent();
            backend = new UserRegistrationBackend(connectionString);
        }


        private void button1register_user_Click(object sender, EventArgs e)
        {

            string username = textBox1username.Text;
            string password = textBox1_password.Text;
            string confirmPassword = textBox2_passwordconfirm.Text;

            backend.PerformRegistration(username, password, confirmPassword, isUserRegistered);

        }

        private void button1back_user_Click(object sender, EventArgs e)
        {

            // Navigate back to the login form or close the registration form
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide(); // Close the registration form

        }

    }
}
