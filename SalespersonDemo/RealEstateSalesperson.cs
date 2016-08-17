using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    class RealEstateSalesperson : Salesperson, ISellable
    {
        private float _totalValueSold;
        private float _totalCommisionEarned;
        private float _commisionRate;

        public RealEstateSalesperson(string first, string last, float commisionRate) : base(first, last)
        {
            this._totalValueSold = 0;
            this._totalCommisionEarned = 0;
            this._commisionRate = commisionRate;
        }

        public float TotalValueSold
        {
            get
            {
                return this._totalValueSold;
            }
            set
            {
                this._totalValueSold = value;
                this.TotalCommisionEarned = this.TotalValueSold * this.CommisionRate;
            }
        }

        public float TotalCommisionEarned
        {
            get
            {
                return this._totalCommisionEarned;
            }
            set
            {
                this._totalCommisionEarned = value;
            }
        }

        public float CommisionRate
        {
            get
            {
                return this._commisionRate;
            }
            set
            {
                this._commisionRate = value;
            }
        }

        public void MakeSale(int dollarValueForAHouse)
        {
            this.SalesSpeech();
            this.TotalValueSold += dollarValueForAHouse;
        }

        public void SalesSpeech()
        {
            Console.WriteLine("I, " + this.GetFullName() + ", just sold a real estate property!");
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Total Value Sold: {0:C}\nTotal Commision Earned: {1:C}\nCommision Rate: {2:p}\n",
                this.TotalValueSold, this.TotalCommisionEarned, this.CommisionRate);
        }
    }
}
