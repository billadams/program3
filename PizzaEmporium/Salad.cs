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
    class Salad : Product
    {
        private string mType;

        public Salad()
        {

        }

        public Salad(int id, string description, string type)
            : base(id, description)
        {
            this.Type = type;
            this.Price = GetSaladPrice();
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

        public decimal GetSaladPrice()
        {
            decimal typeCost = 0.0M;

            switch (Type)
            {
                case "House":
                    typeCost = 4.89M;
                    break;
                case "Chef":
                    typeCost = 6.79M;
                    break;
                case "Insalata":
                    typeCost = 9.29M;
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
