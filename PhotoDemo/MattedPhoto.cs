using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    class MattedPhoto : Photo
    {
        public string Color { get; set; }

        public MattedPhoto(int width, int height, string color) : base(width, height)
        {
            this.Color = color;
        }

        protected override void calculatePrice()
        {
            base.calculatePrice();
            this.price += 10;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Color: {0}\n", this.Color);
        }
    }
}
