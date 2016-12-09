using System;
using System.Collections.Generic;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    /*****************************************************************
    * Name: Bill Adams
    * Project: Program 3
    * Date: 12/8/2016
    * Description: Order pizza and other items.
    * **************************************************************/
    public static class InvoiceItem
    {
        public static StringBuilder PrintReceipt(Order order)
        {
            List<Product> products = new List<Product>();
            decimal subTotal = 0.0M;
            StringBuilder output = new StringBuilder();

            // Format the receipt form.
            output.Append("Thank you for choosing the Pizza Emporium\r\r\n");
            output.Append("-----------------------------------------\r\n");
            output.Append("Qty    Description                  Price\r\n");
            output.Append("-----------------------------------------\r\n");

            // We have access to toppings and other items here...
            products = order.Products;
            // But not here once we use type Product...
                foreach (Product product in products)
                {
                if (product.GetType().Name == "Specials")
                {
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, "Special", product.Price.ToString(("n2")) + "\r\n"));
                    string[] items = product.Description.Split(',');
                    foreach (string item in items)
                    {
                        output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", "", "- " + item.Trim(), "" + "\r\n"));
                    }
                }
                else if (product.GetType().Name == "Salad")
                {
                    // Cast product to salad so we can get a few of salad's properties.
                    Salad salad = (Salad)product;
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, salad.Type + " " + product.Description, product.Price.ToString(("n2")) + "\r\n"));
                }
                else if (product.GetType().Name == "Pizza")
                {
                    // Cast product to pizza so we can get a few of pizza's properties.
                    Pizza pizza = (Pizza)product;
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, pizza.Size  + " " + product.Description, product.Price.ToString(("n2")) + "\r\n"));

                    for (int i = 0; i < pizza.Toppings.Length; i++)
                    {
                        output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", "", "- " + pizza.Toppings[i].Trim(), "" + "\r\n"));
                    }
                }
                else if (product.GetType().Name == "Promotional")
                {
                    // Cast product to promotional so we can get a few of promotional's properties.
                    Promotional promotional = (Promotional)product;
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, product.Description, product.Price.ToString(("n2")) + "\r\n"));

                    for (int i = 0; i < promotional.Items.Length; i++)
                    {
                        output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", "", "- " + promotional.Items[i].Trim(), "" + "\r\n"));
                    }
                }
                else if (product.GetType().Name == "Drink")
                {
                    // Cast product to drink so we can get a few of drink's properties.
                    Drink drink = (Drink)product;
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, drink.Size + " " + product.Description, product.Price.ToString(("n2")) + "\r\n"));
                }
                else
                {
                    output.Append(String.Format("{0, -5}  {1, -28} {2, 7}", 1, product.Description, product.Price.ToString(("n2")) + "\r\n"));
                }
                subTotal += product.Price;
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
