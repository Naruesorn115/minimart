using Microsoft.Data.SqlClient;

namespace Minimart
{
    public class connectDB
    {
        public static SqlConnection ConnectMinimart()
        {
          
            string conString = @"Data Source=LAPTOP-LKOJ4HLG\SQLExpress;Initial Catalog=Minimart;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
    }
}