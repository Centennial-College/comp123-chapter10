using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDemo
{
    class InsuredPackage : Package
    {
        public double Value { get; set; }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            set
            {
                base.Weight = value;
                this._deliveryPrice += (this.Value > 20) ? 2.50 : 1;
            }

        }

        public InsuredPackage(int id, string name, double weight, double value) : base(id, name, weight)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Package Value: {0:C}\n",
                this.Value);
        }
    }
}
