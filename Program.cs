

using System.Data.SqlClient;

namespace ADO.NetSQLConnection_01
{
    class Program
    {
        static void Main(string[] args)
        {
        string ADONetTestDBConnectionString = "Data Source=.;Initial Catalog=ado.NetTestDB;User ID=sa;Trust Server Certificate=True";

            SqlConnection connection = new SqlConnection(ADONetTestDBConnectionString);

            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Person (FirstName , LastName , Age) Values('Amin' ,'Ghasemi',20 ");



        }

    }
}
