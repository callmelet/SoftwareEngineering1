using System;
using System.Data.SqlClient;

namespace SoftwareEngineering
{
    internal class UserprofileBackend
    {
        // Connection string to the database
        private readonly string connectionString = ConnectionString.DBConnectionString;

        // Method to load user data from the database
        public UserProfileModel LoadUserData()
        {
            // Get the username from the LoginInfo class
            string username = LoginInfo.UserName;
            SqlDataReader reader = null;
            UserProfileModel model = new UserProfileModel();

            try
            {
                // Connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [user_table] WHERE Username = @Username";

                    // Execute the query to retrieve user data
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        reader = command.ExecuteReader();

                        // If reader is not empty, setting the UserProfileModel with User profile details from Database
                        if (reader != null && reader.Read())
                        {
                            model.Name = reader["Name"].ToString();
                            model.Surname = reader["Surname"].ToString();
                            model.Email = reader["Email"].ToString();
                            model.Phone = reader["Phone"].ToString();
                            reader.Close();
                        }
                    }
                }
                // return the userProfileModel
                return model;
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public int UpdateName(string name, string username)
        {
            int rowsAffected = 0;
            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                string query = "UPDATE [user_table]" +
                    "SET Name = @Name where Username = @Username ";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
                return rowsAffected;
        }

        // Similar methods to update user details in the database (UpdateName, UpdateSurname, UpdateEmail, UpdatePhone)
        public int UpdateSurname(string surname, string username)
        {
            int rowsAffected = 0;
            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                string query = "UPDATE [user_table]" +
                    "SET Surname = @Surname where Username = @Username ";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public int UpdateEmail(string email, string username)
        {
            int rowsAffected = 0;
            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                string query = "UPDATE [user_table]" + "SET Email = @Email where Username = @Username ";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        public int UpdatePhone(string phone, string username)
        {
            int rowsAffected = 0;
            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                string query = "UPDATE [user_table]" + "SET Phone = @Phone where Username = @Username ";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

    }
}
