using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEmporium
{
    class Order : IOrder
    {
        private int mOrderID;
        private DateTime mToday;
        private string mBranchName = "Bill Adams";
        private decimal mOrderTax;
        private decimal mOrderTotal;

        //private List<Order> orders;

        public Order()
        {

        }

        public Order(int orderID)
        {
            this.OrderID = orderID;
            this.Date = DateTime.Today;
        }

        public string BranchName
        {
            get
            {
                return mBranchName;
            }
        }

        public DateTime Date
        {
            get
            {
                return mToday;
            }

            set
            {
                mToday = value;
            }
        }

        public int OrderID
        {
            get
            {
                return mOrderID;
            }

            set
            {
                mOrderID = value;
            }
        }

        public decimal OrderTax
        {
            get
            {
                return mOrderTax;
            }
            set
            {
                mOrderTax = value;
            }
        }
        public decimal OrderTotal
        {
            get
            {
                return mOrderTotal;
            }

            set
            {
                mOrderTotal = value;
            }
        }

        public void AddItem()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateTax()
        {
            throw new NotImplementedException();
        }

        public void DeleteItem()
        {
            throw new NotImplementedException();
        }

        public void SaveOrder()
        {
            throw new NotImplementedException();
        }

        public decimal TotalOrder()
        {
            throw new NotImplementedException();
        }
    }
}
