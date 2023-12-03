using System;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    public partial class UserRegistrationForm : Form
    {
        
        private readonly UserRegistrationBackend backend;
        private bool isUserRegistered = false; // Flag to track user registration status

        public UserRegistrationForm()
        {
            InitializeComponent();
            backend = new UserRegistrationBackend();
        }


        private void button1register_user_Click(object sender, EventArgs e)
        {

            string username = textBox1username.Text;
            string password = textBox1_password.Text;
            string confirmPassword = textBox2_passwordconfirm.Text;

            // Existing registration logic from button1register_user_Click
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }
            int userCount=backend.CheckUserExistsOrNot(username);
            if(userCount==0)
            {
                int rowsAffected=backend.PerformRegistration(username, password);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful. You can now log in.");
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    this.Hide(); // Close the registration form
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("User already exists.Please login.");
                Homepage homepage = new Homepage();
                homepage.Show();
                this.Hide(); // Close the registration form
            }
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
