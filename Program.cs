

using System.Data.SqlClient;

namespace ADO.NetSQLConnection_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string ADONetTestDBConnectionString =
                """
            Data Source=.;
            Initial Catalog=DotNetTestDB;
            User ID=sa;Password=amin5123;
            Encrypt=False
            """;
            //add CatalogeName
            var connection = new SqlConnection(ADONetTestDBConnectionString);

            connection.Open();
            var cmd = new SqlCommand(
                """
                INSERT INTO Person 
                    (FirstName, LastName, Age) 
                VALUES 
                    ('Amin', 'Ghasemi', 20)
                """, connection);
            var rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowsAffected);
            //ExecuteNonQuery() returns the number of rows affected by the command
            //And send the command to the database.
            connection.Close();

        }

    }
}
