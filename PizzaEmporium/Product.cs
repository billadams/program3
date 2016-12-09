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
    public abstract class Product
    {
        private int mID;
        private string mDescription;
        private decimal mPrice;

        public Product()
        {

        }

        public Product(int id, string description)
        {
            this.ID = id;
            this.Description = description;
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

        public abstract string GetDisplayText();
    }
}
