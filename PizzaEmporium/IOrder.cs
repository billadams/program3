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
    public interface IOrder
    {
        decimal CalculateTax(decimal price);

        decimal TotalOrder(decimal price);

        void AddItem(Product product);

        bool SaveOrder();

        void DeleteItem(int index);

        int OrderID
        {
            get;
            set;
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
