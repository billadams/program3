using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    public interface IOrder
    {
        decimal CalculateTax(decimal price);

        decimal TotalOrder(decimal price);

        void AddItem(Product product);

        void SaveOrder();

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
