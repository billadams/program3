using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    class Drink : Product
    {
        private string mSize;

        public Drink()
        {

        }

        public Drink(int id, string description, decimal price, string size)
            : base(id, description, price)
        {
            this.Size = size;
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


    }
}
