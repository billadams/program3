using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    public interface IOrder
    {
        decimal CalculateTax();

        decimal TotalOrder();

        void AddItem();

        void SaveOrder();

        void DeleteItem();

        int OrderID
        {
            get;
            set;
        }

        DateTime Date
        {
            get;
            set;
        }

        string BranchName
        {
            get;
            //set;
        }

        decimal OrderTotal
        {
            get;
            set;
        }

        decimal OrderTax
        {
            get;
            set;
        }
    }
}
