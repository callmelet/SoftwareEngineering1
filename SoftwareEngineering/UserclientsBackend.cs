using System.Data.SqlClient;

namespace SoftwareEngineering
{
    internal class UserclientsBackend
    {
        private readonly string connectionString = ConnectionString.DBConnectionString;
        private SqlDataAdapter dataAdapter;

        public SqlDataAdapter InitializeDataSet()
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM Clients", connectionString);            
            return dataAdapter;
        }

    }
}
