using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    public abstract class Product
    {
        private int mID;
        private string mDescription;
        private decimal mPrice;

        public Product()
        {

        }

        public Product(int id, string description, decimal price)
        {
            this.ID = id;
            this.Description = description;
            this.Price = price;
        }

        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }

        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }


    }
}
