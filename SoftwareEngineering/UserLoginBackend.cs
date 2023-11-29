using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    internal class UserLoginBackend
    {
        private readonly string connectionString;

        public UserLoginBackend(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void PerformLogin(string username, string password, Form currentForm)
        {
            //string username = textBox1username_user.Text;
            //string password = textBox1userpassword.Text;

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
                                currentForm.Hide();
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

    }
}
