using System.Data.SqlClient;

namespace SoftwareEngineering
{
    // Backend class for user registration logic
    internal class UserRegistrationBackend
    {
        // Connection string to the database, retrieved from the ConnectionString class
        private readonly string connectionString = ConnectionString.DBConnectionString;

        // Method to check if the user already exists in the database
        public int CheckUserExistsOrNot(string username)
        {
            int userCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the user already exists in the Users table
                string checkUserQuery = "SELECT COUNT(*) FROM user_table WHERE Username = @Username";

                using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                {
                    checkUserCommand.Parameters.AddWithValue("@Username", username);
                    userCount = (int)checkUserCommand.ExecuteScalar();
                }
            }
            return userCount;
        }

        // Method to perform user registration
        public int PerformRegistration(string username, string password)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to insert a new user into the user_table
                string insertUserQuery = "INSERT INTO user_table (Username, Password, IsUser) VALUES (@Username, @Password, 1)";

                using (SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection))
                {
                    insertUserCommand.Parameters.AddWithValue("@Username", username);
                    insertUserCommand.Parameters.AddWithValue("@Password", password);
                    rowsAffected = insertUserCommand.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }
    }
}
