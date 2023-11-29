using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    internal class UserRegistrationBackend
    {
        private readonly string connectionString;

        public UserRegistrationBackend(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void PerformRegistration(string username, string password, string confirmPassword, bool isUserRegistered)
        {
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

    }
}
