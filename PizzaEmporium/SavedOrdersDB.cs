using System.Data.SqlClient;

namespace PizzaEmporium
{
    /*****************************************************************
    * Name: Bill Adams
    * Project: Program 3
    * Date: 12/8/2016
    * Description: Order pizza and other items.
    * **************************************************************/
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