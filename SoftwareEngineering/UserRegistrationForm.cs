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
        private bool isUserRegistered = false; // Flag to track user registration status
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";


        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void textBox1username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_passwordconfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1register_user_Click(object sender, EventArgs e)
        {

            string username = textBox1username.Text;
            string password = textBox1_password.Text;
            string confirmPassword = textBox2_passwordconfirm.Text;

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

            // Check if the user is already registered
            if (isUserRegistered)
            {
                MessageBox.Show("User has already been registered. Please log in.");
            }
            else
            {
                // Implement registration logic by inserting the user into the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the user already exists in the Users table
                    string checkUserQuery = "SELECT COUNT(*) FROM user_table WHERE Username = @Username";

                    using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                    {
                        checkUserCommand.Parameters.AddWithValue("@Username", username);
                        int userCount = (int)checkUserCommand.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("User already exists. Please log in.");
                        }
                        else
                        {
                            // Insert the user into the Users table
                            string insertUserQuery = "INSERT INTO user_table (Username, Password, IsUser) VALUES (@Username, @Password, 1)";

                            using (SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection))
                            {
                                insertUserCommand.Parameters.AddWithValue("@Username", username);
                                insertUserCommand.Parameters.AddWithValue("@Password", password);

                                int rowsAffected = insertUserCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Registration successful. You can now log in.");
                                    isUserRegistered = true;
                                }
                                else
                                {
                                    MessageBox.Show("Registration failed. Please try again.");
                                }
                            }
                        }
                    }
                }
            }

        }

        private void button1back_user_Click(object sender, EventArgs e)
        {

            // Navigate back to the login form or close the registration form
            this.Close(); // Close the registration form

        }
    }
}
