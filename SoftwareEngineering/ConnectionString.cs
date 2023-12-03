using System.Configuration;

namespace SoftwareEngineering
{
    public static class ConnectionString
    {
        public static string DBConnectionString= ConfigurationManager.ConnectionStrings["VendorApplicationConnectionString"].ConnectionString;

    }
}
