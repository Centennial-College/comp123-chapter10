using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    abstract class Salesperson
    {
        private string _firstName;
        private string _lastName;

        public Salesperson(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public override string ToString()
        {
            return string.Format("{0}\n-----------------------\nFull Name: {1}\n",
                this.GetType().ToString().Substring(this.GetType().ToString().IndexOf(".") + 1), this.GetFullName());
        }
    }
}
