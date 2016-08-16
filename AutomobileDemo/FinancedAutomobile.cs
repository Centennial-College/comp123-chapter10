using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    class FinancedAutomobile : Automobile
    {
        public double AmountFinanced { get; set; }
        public double InterestRate { get; set; }

        public FinancedAutomobile(int id, string make, int year, double price, double amtFinanced, double rate) : base(id, make, year, price)
        {
            this.AmountFinanced = amtFinanced;
            this.InterestRate = rate;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Amount Financed: {0:C}\nInterest Rate {1:p}\n",
                this.AmountFinanced, this.InterestRate);
        }
    }
}
