

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
            
            /*
            var cmdInsert = new SqlCommand(
                """
                INSERT INTO Person 
                    (FirstName, LastName, Age) 
                VALUES 
                    ('Amin', 'Ghasemi', 20)
                """, connection);
            var rowsAffected = cmdInsert.ExecuteNonQuery();
            Console.WriteLine(rowsAffected);
            */
            //ExecuteNonQuery() returns the number of rows affected by the command
            //And send the command to the database.
            
            var cmdDel = new SqlCommand(
                """
                DELETE FROM Person
                WHERE FirstName = 'Amin'
                """, connection);
            var rowsAffected = cmdDel.ExecuteNonQuery();
            Console.WriteLine(rowsAffected);
            //cmdDel added in case you need to delete inserted data.

            connection.Close();

        }

    }
}
