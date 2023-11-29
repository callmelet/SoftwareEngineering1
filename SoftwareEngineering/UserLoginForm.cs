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
    public partial class UserLoginForm : Form
    {
        private readonly UserLoginBackend backend;
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";
        
        public UserLoginForm()
        {
            InitializeComponent();
            backend = new UserLoginBackend(connectionString);
        }


        private void loginbutton1_user_Click(object sender, EventArgs e)
        {
            string username = textBox1username_user.Text;
            string password = textBox1userpassword.Text;

            backend.PerformLogin(username, password, this);
        }
         

        private void backbutton_Click(object sender, EventArgs e)
        {
            // Go back to the homepage
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
