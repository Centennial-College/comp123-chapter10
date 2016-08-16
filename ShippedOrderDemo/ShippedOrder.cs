using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderDemo;

namespace ShippedOrderDemo
{
    class ShippedOrder : Order
    {
        public static int OrderNumber = 1;
        private const double SHIPPING_FEE = 4.00;

        public ShippedOrder(string custName, int qnty) : base(OrderNumber++, custName, qnty)
        {
        }

        public override int Quantity
        {
            get
            {
                return base.Quantity;
            }

            set
            {
                base.Quantity = value;
                this.totalPrice += SHIPPING_FEE;
            }
        }
    }
}
