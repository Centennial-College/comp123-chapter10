using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class GirlScout : Salesperson, ISellable
    {
        private int _boxesCookiesSold;

        public GirlScout(string first, string last) : base(first, last)
        {
            this.BoxesCookiesSold = 0;
        }

        public int BoxesCookiesSold
        {
            get
            {
                return this._boxesCookiesSold;
            }
            set
            {
                this._boxesCookiesSold = value;
            }
        }

        public void MakeSale(int numBoxes)
        {
            this.SalesSpeech();
            this.BoxesCookiesSold += numBoxes;
        }

        public void SalesSpeech()
        {
            Console.WriteLine("I, " + this.GetFullName() + ", just sold some cookies!");
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Boxes of Cookes Sold: {0}\n", this.BoxesCookiesSold);
        }
    }
}
