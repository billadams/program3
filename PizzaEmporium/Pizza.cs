using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    class Pizza : Product
    {
        private string mSize;
        private string[] mToppings;

        public Pizza()
        {

        }

        public Pizza(int id, string description, decimal price, string size, string[] toppings) 
            : base (id, description, price)
        {
            this.Size = size;
            this.Toppings = toppings;
        }

        public string Size
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }

        public string[] Toppings
        {
            get
            {
                return mToppings;
            }
            set
            {
                mToppings = value;
            }
        }

        public decimal GetPizzaPrice(int quantity)
        {
            decimal pizzaCost = Price * quantity;

            return pizzaCost;
        }
    }
}
