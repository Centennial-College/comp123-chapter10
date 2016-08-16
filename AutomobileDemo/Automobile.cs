using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    class Automobile : IComparable
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Automobile(int id, string make, int year, double price)
        {
            this.ID = id;
            this.Make = make;
            this.Year = year;
            this.Price = price;
        }

        public int CompareTo(object obj)
        {
            Automobile other = (Automobile)obj;
            if (this.ID > other.ID)
                return 1;
            else if (this.ID == other.ID)
                return 0;
            else
                return -1;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nMake: {1}\nYear: {2}\nPrice: {3:C}\n",
                this.ID, this.Make, this.Year, this.Price);
        }
    }
}
