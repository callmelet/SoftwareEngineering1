using System;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class UserLoginForm : Form
    {
        private readonly UserLoginBackend backend;

        // Constructor for the UserLoginForm
        public UserLoginForm()
        {
            InitializeComponent();
            backend = new UserLoginBackend();
        }

        // Event handler for the "Login" button click
        private void loginbutton1_user_Click(object sender, EventArgs e)
        {
            // Retrieve user-entered values from textboxes
            string username = textBox1username_user.Text;
            string password = textBox1userpassword.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both username and password.");
                return;
            }

            // Invoke the PerformLogin method in the backend to check user credentials
            bool userLogged =backend.PerformLogin(username, password, this);
            if (userLogged)
            {
                // Password matches; login successful
                MessageBox.Show("Login successful. Welcome, user!");
                LoginInfo.UserName = username;

                // Open the Userpage form
                Userpage userPage = new Userpage();
                userPage.Show();
                this.Hide();
            }
            else
            {
                // Password is incorrect
                MessageBox.Show("Username or Password is incorrect. Please try again.");
            }
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
