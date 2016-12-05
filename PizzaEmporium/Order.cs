using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    public class Order : IOrder
    {
        private int mOrderID;
        private int mQuantity;
        private decimal mOrderTax;
        private decimal mOrderTotal;
        private List<Product> products = new List<Product>();
        private static int nextNumber = 5000;

        public Order()
        {
            OrderID = nextNumber;
            nextNumber++;
        }

        public Order(Product product)
        {
            OrderID = nextNumber;
            nextNumber++;
            AddItem(product);
        }

        //public Product this[int i]
        //{
        //    get
        //    {
        //        return products[i];
        //    }
        //    set
        //    {
        //        products[i] = value;
        //    }
        //}

        public int OrderID
        {
            get
            {
                return mOrderID;
            }

            set
            {
                mOrderID = value;
            }
        }

        public decimal OrderTax
        {
            get
            {
                return mOrderTax;
            }
            set
            {
                mOrderTax = value;
            }
        }
        public decimal OrderTotal
        {
            get
            {
                return mOrderTotal;
            }

            set
            {
                mOrderTotal = value;
            }
        }

        public void AddItem(Product product)
        {
            products.Add(product);
            this.OrderTax += CalculateTax(product.Price);
            this.OrderTotal += TotalOrder(product.Price);
        }

        public void DeleteItem(int index)
        {
            Product currentProduct = products[index];

            this.OrderTax -= CalculateTax(currentProduct.Price);
            this.OrderTotal -= TotalOrder(currentProduct.Price);
            products.RemoveAt(index);
        }

        public void SaveOrder()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateTax(decimal price)
        {
            decimal tax = .07M;
            decimal productTax = 0M;

            productTax = price * tax;

            return productTax;
        }

        public decimal TotalOrder(decimal price)
        {
            decimal total = 0M;

            total = price + CalculateTax(price);

            return total;
        }
    }
}
