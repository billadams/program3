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

        public Pizza(int id, string description, string size, string[] toppings) 
            : base (id, description)
        {
            this.Size = size;
            this.Toppings = toppings;
            this.Price = GetPizzaPrice();
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

        public decimal GetPizzaPrice()
        {
            decimal sizeCost = 0.0M;
            int numToppings = Toppings.Length;

            switch (Size)
            {
                case "Small":
                    sizeCost = 9.89M;
                    break;
                case "Medium":
                    sizeCost = 12.69M;
                    break;
                case "Large":
                    sizeCost = 15.29M;
                    break;
            }

            decimal toppingsCost = numToppings * 1.50M;

            decimal pizzaCost = sizeCost + toppingsCost;

            return pizzaCost;
        }

        public string[] GetPizzaToppings(Pizza pizza)
        {
            string[] toppings = this.Toppings;

            return toppings;
        }

        public override string GetDisplayText()
        {
            return this.Size + " " + this.Description + " " +
                "(" + this.GetToppingsList() + ") - " + Price.ToString("c"); 
        }

        public string GetToppingsList()
        {
            string output = "";

            for (int i = 0; i < Toppings.Length; i++)
            {
                output += Toppings[i];
                if (i < (Toppings.Length - 1))
                {
                    output += ", ";
                }
            }

            return output;
        }

    }
}
