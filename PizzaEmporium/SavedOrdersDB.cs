using System.Data.SqlClient;

namespace PizzaEmporium
{
    public static class SavedOrdersDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SavedOrders.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;

        }
    }
}