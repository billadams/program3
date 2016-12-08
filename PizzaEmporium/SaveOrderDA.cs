using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    public static class SaveOrderDA
    {
        public static bool SaveOrder(Order order)
        {
            DateTime date = DateTime.Today;
            SqlConnection connection = SavedOrdersDB.GetConnection();
            string insertStatement =
                "INSERT SavedOrders " +
                "(OrderID, Date, BranchName, OrderTotal) " +
                "VALUES (@OrderID, @Date, @BranchName, @OrderTotal)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@OrderID", order.OrderID);
            insertCommand.Parameters.AddWithValue("@Date", date);
            insertCommand.Parameters.AddWithValue("@BranchName", "Bill Adams");
            insertCommand.Parameters.AddWithValue("@OrderTotal", order.OrderTotal);

            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
