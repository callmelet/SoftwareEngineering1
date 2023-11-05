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
        private string connectionString = "Server=BOOK-5A3M5LR9FE;Database=VendorApplication;Integrated Security=True;";
        
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
            }
            else if (radioButtonADMIN.Checked)
            {
                // The user selected "Admin" and clicked "Login"
                AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
            }

            //code for login page for user and admin
            string username = "user123"; // Replace with the username entered by the user
            string password = "hashedpassword123"; // Replace with the hashed password entered by the user

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve UserType from your database
                string query = "SELECT UserType FROM dbo.user_table WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    string userType = (string)command.ExecuteScalar();

                    if (userType == "User")
                    {
                        // The user is a regular user
                        // Open the user-specific form or perform user-related actions
                    }
                    else if (userType == "Admin")
                    {
                        // The user is an admin
                        // Open the admin-specific form or perform admin-related actions
                    }
                }

                connection.Close();
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
            }
            else if (radioButtonADMIN.Checked)
            {
                // The user selected "Admin" and clicked "Register"
                AdminRegistrationForm adminRegistrationForm = new AdminRegistrationForm();
                adminRegistrationForm.Show();
            }

            //code for registration page for user and admin
            string username = "user123"; // Replace with the username entered by the user during registration
            string password = "hashedpassword123"; // Replace with the hashed password entered by the user during registration
            string userType = radioButtonUSER.Checked ? "User" : "Admin"; // Determine the user's role based on the radio button selection

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to insert a new user or admin into your database
                string query = "INSERT INTO " + (userType == "User" ? "dbo.user_table" : "dbo.admin_table") + " (Username, Password, UserType) VALUES (@Username, @Password, @UserType)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@UserType", userType);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }

                connection.Close();
            }



        }
    }
}
