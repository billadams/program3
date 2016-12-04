using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    class Specials : Product
    {
        private string mType;

        public Specials()
        {

        }

        public Specials(int id, string description, string type)
            : base(id, description)
        {
            this.Type = type;
            this.Price = GetSpecialPrice();
        }

        public string Type
        {
            get
            {
                return mType;
            }
            set
            {
                mType = value;
            }
        }

        public decimal GetSpecialPrice()
        {
            decimal typeCost = 0.0M;
            string[] toppings = { "Hamburger", "Cheese" };

            Pizza pizza = new Pizza(107, "Pizza", "Medium", toppings[01]);

            switch (Type)
            {
                case "special1":
                    typeCost = 4.89M;
                    break;
                case "special2":
                    typeCost = 6.79M;
                    break;
            }

            return typeCost;
        }

        public override string GetDisplayText()
        {
            return this.Type + " " + this.Description + " - " + this.Price.ToString("c");
        }
    }
}
