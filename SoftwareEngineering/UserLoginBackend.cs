using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    internal class UserLoginBackend
    {
        private readonly string connectionString=ConnectionString.DBConnectionString;

        // Method to perform user login
        public bool PerformLogin(string username, string password, Form currentForm)
        {
            bool isLogged=false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the user exists in the Users table
                string checkUserQuery = "SELECT IsUser FROM user_table WHERE Username = @Username";

                using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                {
                    bool isUser = false;
                    checkUserCommand.Parameters.AddWithValue("@Username", username);

                    // Execute the SQL command to retrieve user details (IsUser) from the database
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
                            // Set the parameter for the username
                            checkPasswordCommand.Parameters.AddWithValue("@Username", username);
                            // Retrieve the stored password from the database
                            string storedPassword = (string)checkPasswordCommand.ExecuteScalar();

                            // Compare the entered password with the stored password
                            if (password == storedPassword)
                            {
                               isLogged = true;// Set the login status to true if the passwords match
                            }
                            else
                            {
                                isLogged=false;// Set the login status to false if the passwords do not match
                            }
                        }
                    }
                    // If the user is not registered, set the login status to false
                    else
                    {
                        isLogged = false;
                    }
                }
            }
            return isLogged;
        }

    }
}
