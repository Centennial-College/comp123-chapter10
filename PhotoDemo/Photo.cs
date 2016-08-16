using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class Photo
    {
        private int _width;
        private int _height;
        protected double price;

        public Photo(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
                calculatePrice();
            }
        }

        public int Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
                calculatePrice();
            }
        }

        public double Price
        {
            get { return this.price; }
        }

        protected virtual void calculatePrice()
        {
            if (this.Width == 8 && this.Height == 10)
                this.price = 3.99;
            else if (this.Width == 10 && this.Height == 12)
                this.price = 5.99;
            else
                this.price = 9.99;
        }

        public override string ToString()
        {
            return string.Format("{0}\nWidth: {1} in.\nHeight: {2} in.\nPrice: {3:C}\n",
                this.GetType(), this.Width, this.Height, this.Price);
        }
    }
}
