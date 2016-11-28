using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    public abstract class Product
    {
        public abstract string Description
        {
            get;
            set;
        }

        public abstract decimal Price
        {
            get;
            set;
        }

        public abstract int ID
        {
            get;
            set;
        }
    }
}
