using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SoftwareEngineering
{
    internal class UserRegistrationBackend
    {
        private readonly string connectionString = ConnectionString.DBConnectionString;

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
        public int PerformRegistration(string username, string password)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

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
