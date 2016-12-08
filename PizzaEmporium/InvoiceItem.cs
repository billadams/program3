using System;
using System.Collections.Generic;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    public static class InvoiceItem
    {
        public static StringBuilder PrintReceipt(Order order)
        {
            //string output = "";
            List<Product> products = new List<Product>();
            //const int QTY_WIDTH = 10;
            //const int DESC_WIDTH = 34;
            //const int PRICE_WIDTH = 10;

            StringBuilder output = new StringBuilder();

            output.Append("-----------------------------------------\r\n");
            output.Append("Qty    Description                  Price\r\n"); // 30
            output.Append("-----------------------------------------\r\n");

            products = order.Products;
            foreach (Product p in products)
            {
                output.Append(String.Format("{0, -5}  {1, -28} {2, 5}", 1, p.Description, Convert.ToString(p.Price) + "\r\n"));
            }




            //output.Append("------------------------------");



            //output.Append("Qty".PadRight(QTY_WIDTH));
            //output.Append("Description".PadRight(DESC_WIDTH));
            //output.Append("Price".PadRight(PRICE_WIDTH));
            //output.Append("\n");

            //output.Append("=========".PadRight(QTY_WIDTH));
            //output.Append("=================================".PadRight(DESC_WIDTH));
            //output.Append("=========".PadRight(PRICE_WIDTH));
            //output.Append("\n");


            //output += "Pizza Emporium\n\n";
            //output += DateTime.Today + "\n\n";


            //output += "Order ID: " + order.OrderID + "\n";

            //products = order.Products;
            //foreach(Product p in products)
            //{
            //      output += p.GetDisplayText() + "\n";
            //}

            return output;
        }

    }
}
