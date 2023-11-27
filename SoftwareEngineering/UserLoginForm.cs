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
        private string connectionString = "Data Source=BOOK-5A3M5LR9FE\\SQLEXPRESS;Initial Catalog=VendorApplication;Integrated Security=True";
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void textBox1username_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1userpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton1_user_Click(object sender, EventArgs e)
        {
            string username = textBox1username_user.Text;
            string password = textBox1userpassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both username and password.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the user exists in the Users table
                string checkUserQuery = "SELECT IsUser FROM user_table WHERE Username = @Username";

                using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                {
                    bool isUser = false;
                    checkUserCommand.Parameters.AddWithValue("@Username", username);

                    var userdetails = checkUserCommand.ExecuteScalar();
                    if (userdetails != null)
                    {
                        isUser = (bool)userdetails;
                    }

                 
                    //bool isUser = (bool)checkUserCommand.ExecuteScalar();


                    if (isUser)
                    {
                        // User is registered; check the password
                        string checkPasswordQuery = "SELECT Password FROM user_table WHERE Username = @Username";

                        using (SqlCommand checkPasswordCommand = new SqlCommand(checkPasswordQuery, connection))
                        {
                            checkPasswordCommand.Parameters.AddWithValue("@Username", username);
                            string storedPassword = (string)checkPasswordCommand.ExecuteScalar();

                            if (password == storedPassword)
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
                                MessageBox.Show("Password is incorrect. Please try again.");
                            }
                        }
                    }
                    else
                    {
                        // The user is not registered
                        MessageBox.Show("Login failed. Please check your credentials or register if you haven't already.");
                    }
                }
            }
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
