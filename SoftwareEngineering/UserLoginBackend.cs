using System.Data.SqlClient;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    internal class UserLoginBackend
    {
        private readonly string connectionString=ConnectionString.DBConnectionString;

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
                               isLogged = true;
                            }
                            else
                            {
                                isLogged=false;
                            }
                        }
                    }
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
