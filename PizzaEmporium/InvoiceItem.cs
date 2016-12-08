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
            List<Product> products = new List<Product>();
            decimal subTotal = 0.0M;
            StringBuilder output = new StringBuilder();

            // Format the receipt form.
            output.Append("-----------------------------------------\r\n");
            output.Append("Qty    Description                  Price\r\n"); // 30
            output.Append("-----------------------------------------\r\n"); // 41

            products = order.Products;
            foreach (Product p in products)
            {
                if (p.GetType().Name == "Specials")
                {
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, "Special", p.Price.ToString(("n2")) + "\r\n"));
                    string[] items = p.Description.Split(',');
                    foreach (string item in items)
                    {
                        output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, "- " + item.Trim(), "" + "\r\n"));
                    }
                }
                else if (p.GetType().Name == "Pizza")
                {
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, p.Description, p.Price.ToString(("n2")) + "\r\n"));
                    string[] toppings = (Pizza)p.GetPizzaToppings((Pizza)p);
                    foreach (string topping in toppings)
                    {
                        output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, "- " + topping.Trim(), "" + "\r\n"));
                    }
                }
                else
                {
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, p.Description, p.Price.ToString(("n2")) + "\r\n"));
                }
                subTotal += p.Price;
            }

            output.Append("-----------------------------------------\r\n");
            output.Append(String.Format("{0, -5}  {1, 27} {2, 7}", "", "Subtotal:", subTotal.ToString("c") + "\r\n"));
            output.Append(String.Format("{0, -5}  {1, 27} {2, 8}", "", "Tax:", order.OrderTax.ToString("n2") + "\r\n"));
            output.Append("-----------------------------------------\r\n");
            output.Append(String.Format("{0, -5}  {1, 27} {2, 7}", "", "Grand Total:", order.OrderTotal.ToString("c") + "\r\n"));

            return output;
        }

    }
}
