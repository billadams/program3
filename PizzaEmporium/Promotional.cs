using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    class Promotional : Product
    {
        private string[] mItems;

        public Promotional()
        {

        }

        public Promotional(int id, string description, string[] items)
            : base(id, description)
        {
            this.Items = items;
            this.Price = GetPromotionalPrice();
        }

        public string[] Items
        {
            get
            {
                return mItems;
            }
            set
            {
                mItems = value;
            }

        }
        public decimal GetPromotionalPrice()
        {
            decimal itemCost = 0.0M;

            itemCost = Items.Length * 9.99M;

            return itemCost;
        }

        public override string GetDisplayText()
        {
            return this.Description + " " +
                "(" + this.GetItemsList() + ") - " + Price.ToString("c");
        }

        public string GetItemsList()
        {
            string output = "";

            for (int i = 0; i < Items.Length; i++)
            {
                output += Items[i];
                if (i < (Items.Length - 1))
                {
                    output += ", ";
                }
            }

            return output;
        }
    }
}
