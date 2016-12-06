using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    public static class InvoiceItem
    {
        public static string PrintReceipt(Order order)
        {
            string output = "";
            List<Product> products = new List<Product>();

            output += order.OrderID + "\n";

            products = order.Products;
            foreach(Product p in products)
            {
                output += p.GetDisplayText() + "\n";
            }

            return output;
        }

    }
}
