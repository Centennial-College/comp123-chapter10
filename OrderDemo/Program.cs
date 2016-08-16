using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order(1, "Tom", 15);
            Order o2 = new Order(2, "Billy", 20);
            Order o3 = new Order(3, "Jake", 3);
            Order o4 = new Order(2, "John", 10);

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
            Console.WriteLine(o4);

            Order[] orderArray = { o1, o2, o3, o4 };

            foreach (Order order1 in orderArray)
            {
                foreach (Order order2 in orderArray)
                {
                    DisplayIfOrdersAreEqual(order1, order2);
                }
            }

            DisplayTotalOfOrders(orderArray);
        }

        public static void DisplayIfOrdersAreEqual(Order o1, Order o2)
        {
            Console.WriteLine("It is {0} that Order #: {1} is equal to Order #: {2}",
               o1.Equals(o2), o1.OrderNumber, o2.OrderNumber);
        }

        public static void DisplayTotalOfOrders(Order[] orders)
        {
            double result = 0;
            foreach (Order order in orders)
            {
                result += order.TotalPrice;
            }
            Console.WriteLine("The total price of all the orders is {0:C}", result);
        }
    }
}
