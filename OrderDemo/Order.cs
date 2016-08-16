using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Order
    {
        private int quantity;
        private double totalPrice;

        private const double UNIT_PRICE = 19.95;

        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
                this.totalPrice = this.Quantity * UNIT_PRICE;
            }
        }
        public double TotalPrice
        {
            get
            {
                return this.totalPrice;
            }
        }

        public Order(int number, string custName, int qnty)
        {
            this.OrderNumber = number;
            this.CustomerName = CustomerName;
            this.Quantity = qnty;
        }

        public override bool Equals(object obj)
        {
            Order otherOrder = (Order)obj;

            if (this.OrderNumber == otherOrder.OrderNumber)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.OrderNumber;
        }

        public override string ToString()
        {
            return string.Format("Order Number: {0}\nCustomer Name: {1}\nQuantity: {2}\nTotal Price: {3:C}\n", this.OrderNumber, this.CustomerName, this.Quantity, this.TotalPrice);
        }

    }
}
