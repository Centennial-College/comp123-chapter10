using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderDemo;

namespace ShippedOrderDemo
{
    class ShippedOrder : Order, IComparable
    {
        public static int ORDER_NUMBER = 1;
        private const double SHIPPING_FEE = 4.00;

        public ShippedOrder(string custName, int qnty) : base(ORDER_NUMBER++, custName, qnty)
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

        /**
         * <summary>
         * This method allows ShippedOrder objects to be sorted by order number.
         * It will be called by other methods such as Array.Sort() in order to sort the
         * collection based on order number.
         * </summary>
         * 
         * @public
         * @method CompareTo
         * @params {object} obj
         * @returns {int}
         */
        public int CompareTo(object obj)
        {
            ShippedOrder other = (ShippedOrder)obj;

            if (this.OrderNumber > other.OrderNumber)
                return 1;
            else if (this.OrderNumber == other.OrderNumber)
                return 0;
            else
                return -1;
        }
    }
}
