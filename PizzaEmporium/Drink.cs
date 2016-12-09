using System;
using System.Collections.Generic;
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
    class Drink : Product
    {
        private string mSize;

        public Drink()
        {

        }

        public Drink(int id, string description, string size)
            : base(id, description)
        {
            this.Size = size;
            this.Price = GetDrinkPrice();
        }

        public String Size
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

        public decimal GetDrinkPrice()
        {
            decimal sizeCost = 0.0M;

            switch (Size)
            {
                case "Small":
                    sizeCost = 1.99M;
                    break;
                case "Medium":
                    sizeCost = 2.99M;
                    break;
                case "Large":
                    sizeCost = 3.99M;
                    break;
            }

            return sizeCost;
        }

        public override string GetDisplayText()
        {
            return this.Size + " " + this.Description + " - " + this.Price.ToString("c");
        }
    }
}
