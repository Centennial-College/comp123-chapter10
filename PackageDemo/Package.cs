using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageDemo
{
    class Package
    {
        private double _weight;
        protected double _deliveryPrice;

        public int ID { get; set; }
        public string RecipientName { get; set; }
        public virtual double Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;

                this._deliveryPrice = 5;
                if (this.Weight > 32)
                {
                    this._deliveryPrice += 0.12 * (this.Weight - 32);
                }
            }
        }

        public Package(int id, string name, double weight)
        {
            this.ID = id;
            this.RecipientName = name;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("ID Number: {0}\nRecipient Name: {1}\nPackage Weight: {2}\nDelivery Price: {3:C}\n",
                this.ID, this.RecipientName, this.Weight, this._deliveryPrice);
        }
    }
}
